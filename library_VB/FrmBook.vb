Imports System.IO
Imports DocumentFormat.OpenXml
Imports DocumentFormat.OpenXml.Packaging
Imports DocumentFormat.OpenXml.Spreadsheet
Imports DocumentFormat.OpenXml.Wordprocessing

Public Class FrmBook

    Dim bookarray(4, 4) As Book
    Dim BookCount As Integer

    Public Sub New()
        InitializeComponent()
        bookarray = New Book(4, 4) {}
        BookCount = 0
        lstvBookregister.View = System.Windows.Forms.View.Details
        lstvBookregister.Columns.Add("Name", 100)
        lstvBookregister.Columns.Add("Last Name", 100)
        lstvBookregister.Columns.Add("Title", 100)
        lstvBookregister.Columns.Add("Author", 100)
        lstvBookregister.Columns.Add("Publisher", 100)
        lstvBookregister.Columns.Add("Date", 100)
        lstvBookregister.Columns.Add("End Date", 100)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If txtName.Text = "" Then
            ErrorProvider.SetError(txtName, "You must enter a Name ") ' .SetError muestra el icono y mensaje de error
            txtName.Focus() ' El cursor va a aparecer en este campo (Método .Focus)
            Return
        End If
        ErrorProvider.SetError(txtName, "") ' Limpia el mensaje de error

        If txtLastName.Text = "" Then
            ErrorProvider.SetError(txtLastName, "You must enter a Last Name ")
            txtLastName.Focus()
            Return
        End If
        ErrorProvider.SetError(txtLastName, "")

        If txtTitle.Text = "" Then
            ErrorProvider.SetError(txtTitle, "You must enter a Title ")
            txtTitle.Focus()
            Return
        End If
        ErrorProvider.SetError(txtTitle, "")

        If txtAuthor.Text = "" Then
            ErrorProvider.SetError(txtAuthor, "You must enter an Author ")
            txtAuthor.Focus()
            Return
        End If
        ErrorProvider.SetError(txtAuthor, "")

        If txtPublisher.Text = "" Then
            ErrorProvider.SetError(txtPublisher, "You must enter a Publisher ")
            txtPublisher.Focus()
            Return
        End If
        ErrorProvider.SetError(txtPublisher, "")

        If dtpEndDate.Value < dtpDate.Value Then
            MessageBox.Show("Invalid date. ")
            dtpDate.Value = DateTime.Now
            Return
        End If

        Dim book As New Book()
        book.Name = txtName.Text
        book.Lastname = txtLastName.Text
        book.Title = txtTitle.Text
        book.Author = txtAuthor.Text
        book.Publisher = txtPublisher.Text
        book.Date = Convert.ToDateTime(dtpDate.Text)
        book.Enddate = Convert.ToDateTime(dtpEndDate.Text)

        bookarray(BookCount, 0) = book ' BookCount representa el índice de la fila y 0 representa el índice de la columna

        BookCount += 1
        If BookCount = bookarray.GetLength(0) Then
            MessageBox.Show("Full Arrangement")
        End If

        ' Después de asignar el objeto Book a la matriz, puedes agregar los detalles del libro a lstvBookregister
        Dim item As New ListViewItem(book.Name)
        item.SubItems.Add(book.Lastname)
        item.SubItems.Add(book.Title)
        item.SubItems.Add(book.Author)
        item.SubItems.Add(book.Publisher)
        item.SubItems.Add(book.Date.ToShortDateString())
        item.SubItems.Add(book.Enddate.ToShortDateString())
        lstvBookregister.Items.Add(item)

        txtName.Clear()
        txtLastName.Clear()
        txtTitle.Clear()
        txtAuthor.Clear()
        txtPublisher.Clear()
        dtpDate.Value = DateTime.Now
        dtpEndDate.Value = DateTime.Now


    End Sub

    Private Sub btnExporttxt_Click(sender As Object, e As EventArgs) Handles btnExporttxt.Click
        Exporttxt()
    End Sub

    Private Sub Exporttxt()
        If lstvBookregister.Items.Count = 0 Then
            MessageBox.Show("There is no data to export.", "No data")
            Return
        End If

        Dim dialog As New SaveFileDialog()
        dialog.Filter = "txt files |*.txt"
        dialog.Title = "Save the Text File"
        If dialog.ShowDialog() <> DialogResult.OK Then
            Return
        End If

        Dim filepath As String = dialog.FileName
        Using writer As New StreamWriter(filepath)
            For Each item As ListViewItem In lstvBookregister.Items
                ' Obtener los datos de cada fila del ListView
                Dim name As String = item.SubItems(0).Text
                Dim lastName As String = item.SubItems(1).Text
                Dim title As String = item.SubItems(2).Text
                Dim author As String = item.SubItems(3).Text
                Dim publisher As String = item.SubItems(4).Text
                Dim dateValue As String = item.SubItems(5).Text
                Dim endDate As String = item.SubItems(6).Text

                writer.WriteLine(String.Join(",", name, lastName, title, author, publisher, dateValue, endDate))
            Next
        End Using
        MessageBox.Show("Text file exported successfully :D")
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        Dim frm As New Menu()
        frm.Show()
        Me.Hide()

    End Sub

    Private Sub btnOpentxt_Click(sender As Object, e As EventArgs) Handles btnOpentxt.Click

        Dim dialog As New OpenFileDialog()
        dialog.Filter = "txt files |*.txt"
        dialog.Title = "Open the Text File"
        If dialog.ShowDialog() <> DialogResult.OK Then
            Return
        End If

        Dim filePath As String = dialog.FileName
        Dim lines As String() = File.ReadAllLines(filePath)
        lstvBookregister.Items.Clear()
        For Each line As String In lines
            Dim elements As String() = line.Split(","c) ' Divide los elementos de la línea con el uso de la coma para notar la diferencia 

            Dim item As New ListViewItem(elements(0))
            For i As Integer = 1 To elements.Length - 1
                item.SubItems.Add(elements(i))
            Next

            ' Agregar el ListViewItem al ListView
            lstvBookregister.Items.Add(item)
        Next

    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        If lstvBookregister.Items.Count = 0 Then
            MessageBox.Show("There is no data to export.", "No data")
            Return
        End If

        Dim dialog As New SaveFileDialog()
        dialog.Filter = "Excel files |*.xlsx"
        dialog.Title = "Save the Excel file"
        If dialog.ShowDialog() <> DialogResult.OK Then
            Return
        End If

        Dim filePath As String = dialog.FileName

        Using spreadsheetDocument As SpreadsheetDocument = SpreadsheetDocument.Create(filePath, SpreadsheetDocumentType.Workbook)
            Dim workbookPart As WorkbookPart = spreadsheetDocument.AddWorkbookPart()
            workbookPart.Workbook = New Workbook()

            Dim worksheetPart As WorksheetPart = workbookPart.AddNewPart(Of WorksheetPart)()
            Dim sheetData As New SheetData()
            worksheetPart.Worksheet = New Worksheet(sheetData)

            Dim sheets As Sheets = spreadsheetDocument.WorkbookPart.Workbook.AppendChild(New Sheets())

            Dim sheet As New Sheet() With {.Id = spreadsheetDocument.WorkbookPart.GetIdOfPart(worksheetPart), .SheetId = 1, .Name = "Sheet1"}
            sheets.Append(sheet)

            ' Writing column headers
            Dim headerRow As New Row()
            For Each columnHeader As ColumnHeader In lstvBookregister.Columns
                Dim cell As New Cell()
                cell.DataType = CellValues.String
                cell.CellValue = New CellValue(columnHeader.Text)
                headerRow.AppendChild(cell)
            Next
            sheetData.AppendChild(headerRow)

            ' Writing data rows
            For Each item As ListViewItem In lstvBookregister.Items
                Dim dataRow As New Row()
                For Each subItem As ListViewItem.ListViewSubItem In item.SubItems
                    Dim cell As New Cell()
                    cell.DataType = CellValues.String
                    cell.CellValue = New CellValue(subItem.Text)
                    dataRow.AppendChild(cell)
                Next
                sheetData.AppendChild(dataRow)
            Next
        End Using

        MessageBox.Show("Excel file saved successfully :D")

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If lstvBookregister.SelectedItems.Count > 0 Then
            For Each selectedItem As ListViewItem In lstvBookregister.SelectedItems
                lstvBookregister.Items.Remove(selectedItem)
            Next
        Else
            MessageBox.Show("Please select an item to delete.")
        End If

    End Sub

    Private Sub btnWord_Click(sender As Object, e As EventArgs) Handles btnWord.Click

        If lstvBookregister.Items.Count = 0 Then
            MessageBox.Show("There is no data to export.", "No data")
            Return
        End If

        Dim dialog As New SaveFileDialog()
        dialog.Filter = "Word Documents|*.docx"
        dialog.Title = "Save the Word File"

        If dialog.ShowDialog() <> DialogResult.OK Then
            Return
        End If

        Dim FilePath As String = dialog.FileName
        Using wordDocument As WordprocessingDocument = WordprocessingDocument.Create(FilePath, WordprocessingDocumentType.Document)
            Dim mainPart As MainDocumentPart = wordDocument.AddMainDocumentPart()
            mainPart.Document = New Document()
            Dim body As Body = mainPart.Document.AppendChild(New Body())

            For Each item As ListViewItem In lstvBookregister.Items
                Dim name As String = item.SubItems(0).Text
                Dim lastName As String = item.SubItems(1).Text
                Dim title As String = item.SubItems(2).Text
                Dim author As String = item.SubItems(3).Text
                Dim publisher As String = item.SubItems(4).Text
                Dim dateValue As String = item.SubItems(5).Text
                Dim endDate As String = item.SubItems(6).Text

                ' Crear un nuevo párrafo para cada conjunto de datos
                Dim paragraph As New Paragraph()
                Dim run As New DocumentFormat.OpenXml.Wordprocessing.Run()
                run.AppendChild(New DocumentFormat.OpenXml.Wordprocessing.Text(" Name: " & name & lastName & " Title: " & title & " Author: " & author & " Publisher: " & publisher & " Date: " & dateValue & " End Date: " & endDate))
                paragraph.Append(run)

                body.Append(paragraph)
            Next
        End Using

        MessageBox.Show("Word file exported successfully :D")

    End Sub
End Class