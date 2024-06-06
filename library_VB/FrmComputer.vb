Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Reflection.Metadata
Imports System.Text
Imports System.Threading.Tasks
Imports System.Web
Imports System.Windows.Documents
Imports System.Windows.Forms
Imports System.Xml
Imports System.IO
Imports DocumentFormat.OpenXml
Imports DocumentFormat.OpenXml.Packaging
Imports DocumentFormat.OpenXml.Wordprocessing
Imports Document = DocumentFormat.OpenXml.Wordprocessing.Document
Imports DocumentFormat.OpenXml.Spreadsheet

Public Class FrmComputer

    Public Sub New()
        InitializeComponent()
        lstvComputerregsiter.View = System.Windows.Forms.View.Details
        lstvComputerregsiter.Columns.Add("Name", 100)
        lstvComputerregsiter.Columns.Add("Last Name", 100)
        lstvComputerregsiter.Columns.Add("Computer Number", 100)
        lstvComputerregsiter.Columns.Add("Print Number", 100)
        lstvComputerregsiter.Columns.Add("Date", 100)
        lstvComputerregsiter.Columns.Add("Total")
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


        If cboboxComputernumber.Text = "" Then
            ErrorProvider.SetError(cboboxComputernumber, "You must enter a computer number  ")
            cboboxComputernumber.Focus()
            Return
        End If
        ErrorProvider.SetError(cboboxComputernumber, "")


        If txtPrintNumber.Text = "" Then
            ErrorProvider.SetError(txtPrintNumber, "You must enter an number of prints ")
            txtPrintNumber.Focus()
            Return
        End If
        ErrorProvider.SetError(txtPrintNumber, "")

        'Try-catch bloques son iguales

        Try
            Dim computer As New Computer(Convert.ToString(txtName.Text), Convert.ToString(txtLastName.Text), Convert.ToDateTime(dtpDate.Text), Convert.ToUInt16(cboboxComputernumber.Text), Convert.ToInt16(txtPrintNumber.Text))
            computer.Name = txtName.Text
            computer.Lastname = txtLastName.Text
            computer.Computernumber = Convert.ToInt16(cboboxComputernumber.Text)
            computer.Print_number = Convert.ToInt16(txtPrintNumber.Text)
            computer.Date = Convert.ToDateTime(dtpDate.Text)

            Dim item As New ListViewItem(computer.Name)
            item.SubItems.Add(computer.Lastname)
            item.SubItems.Add(computer.Computernumber.ToString())
            item.SubItems.Add(computer.Print_number.ToString())
            item.SubItems.Add(computer.Date.ToShortDateString())
            item.SubItems.Add(computer.Gettotal(computer.Cost, computer.Print_number).ToString())
            lstvComputerregsiter.Items.Add(item)
            lblTotal.Text = "TOTAL: " & Math.Round(computer.Gettotal(computer.Cost, computer.Print_number), 2).ToString()

            txtName.Clear()
            txtLastName.Clear()
            txtPrintNumber.Clear()
            dtpDate.Value = DateTime.Now

        Catch ex As Exception
            MessageBox.Show("Enter data in a correct format")
            Return

        End Try

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        Dim frm As New Menu()
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub btnExporttxt_Click(sender As Object, e As EventArgs) Handles btnExporttxt.Click

        If lstvComputerregsiter.Items.Count = 0 Then
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
            For Each item As ListViewItem In lstvComputerregsiter.Items
                ' Obtener los datos de cada fila del ListView
                Dim name As String = item.SubItems(0).Text
                Dim lastName As String = item.SubItems(1).Text
                Dim computernumber As String = item.SubItems(2).Text
                Dim printnumber As String = item.SubItems(3).Text
                Dim [date] As String = item.SubItems(4).Text
                Dim total As String = item.SubItems(5).Text

                writer.WriteLine(String.Join(",", name, lastName, computernumber, printnumber, [date], total))
            Next
        End Using
        MessageBox.Show("Text file exported successfully :D")


    End Sub

    Private Sub btnWord_Click(sender As Object, e As EventArgs) Handles btnWord.Click

        If lstvComputerregsiter.Items.Count = 0 Then
            MessageBox.Show("There is no data to export.", "No data")
            Return
        End If

        Dim dialog As New SaveFileDialog
        dialog.Filter = "Word Documents|*.docx"
        dialog.Title = "Save the Word File"

        If dialog.ShowDialog <> DialogResult.OK Then
            Return
        End If

        Dim FilePath = dialog.FileName
        Using wordDocument = WordprocessingDocument.Create(FilePath, WordprocessingDocumentType.Document)
            Dim mainPart = wordDocument.AddMainDocumentPart
            mainPart.Document = New Document
            Dim _body = mainPart.Document.AppendChild(New Body)

            For Each item As ListViewItem In lstvComputerregsiter.Items
                Dim name = item.SubItems(0).Text
                Dim lastName = item.SubItems(1).Text
                Dim computernumber = item.SubItems(2).Text
                Dim printnumber = item.SubItems(3).Text
                Dim [date] = item.SubItems(4).Text
                Dim total = item.SubItems(5).Text

                ' Crear un nuevo párrafo para cada conjunto de datos
                Dim paragraph As New DocumentFormat.OpenXml.Drawing.Paragraph
                Dim _run As New DocumentFormat.OpenXml.Drawing.Run
                _run.AppendChild(New DocumentFormat.OpenXml.Drawing.Text(" Name: " & name & " " & lastName & " Computer Number: " & computernumber & " Print Number: " & printnumber & " Date: " & [date] & " Total :" & total))
                paragraph.Append(_run)
                _body.Append(paragraph)
            Next
        End Using

        MessageBox.Show("Word file exported successfully :D")


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
        lstvComputerregsiter.Items.Clear()

        For Each line As String In lines
            Dim elements As String() = line.Split(","c) ' Divide los elementos de la línea con el uso de la coma para notar la diferencia

            Dim item As New ListViewItem(elements(0))
            For i As Integer = 1 To elements.Length - 1
                item.SubItems.Add(elements(i))
            Next

            ' Agregar el ListViewItem al ListView
            lstvComputerregsiter.Items.Add(item)
        Next


    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If lstvComputerregsiter.SelectedItems.Count > 0 Then
            For Each selectedItem As ListViewItem In lstvComputerregsiter.SelectedItems
                lstvComputerregsiter.Items.Remove(selectedItem)
            Next
        Else
            MessageBox.Show("Please select an item to delete.")
        End If


    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click

        If lstvComputerregsiter.Items.Count = 0 Then
            MessageBox.Show("There is no data to export.", "No data")
            Return
        End If

        Dim dialog As New SaveFileDialog()
        dialog.Filter = "Excel files |*.xlsx"
        dialog.Title = "Save the excel file"
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

            ' Escribir encabezados de columna
            Dim headerRow As New Row()
            For Each columnHeader As ColumnHeader In lstvComputerregsiter.Columns
                Dim cell As New Cell()
                cell.DataType = CellValues.String
                cell.CellValue = New CellValue(columnHeader.Text)
                headerRow.AppendChild(cell)
            Next
            sheetData.AppendChild(headerRow)

            ' Escribir filas de datos
            For Each item As ListViewItem In lstvComputerregsiter.Items
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




    End Sub

    Private Sub btnXml_Click(sender As Object, e As EventArgs) Handles btnXml.Click

        If lstvComputerregsiter.Items.Count = 0 Then
            MessageBox.Show("There is no data to export.", "No data")
            Return
        End If

        Dim dialog As New SaveFileDialog()
        dialog.Filter = "Xml Document|*.xml"
        dialog.Title = "Save the xml File"

        If dialog.ShowDialog() <> DialogResult.OK Then
            Return
        End If

        Dim filePath As String = dialog.FileName

        Dim xmlDoc As New XmlDocument()

        ' Crear el elemento raíz
        Dim rootElement As XmlElement = xmlDoc.CreateElement("Tickets")
        xmlDoc.AppendChild(rootElement)

        For Each item As ListViewItem In lstvComputerregsiter.Items
            Dim ticketElement As XmlElement = xmlDoc.CreateElement("Ticket")

            Dim defaultLibraryName As String = "GREEN LIBRARY"
            Dim libraryNameElement As XmlElement = xmlDoc.CreateElement("LibraryName")
            libraryNameElement.InnerText = defaultLibraryName
            ticketElement.AppendChild(libraryNameElement)

            Dim numberOfCopiesElement As XmlElement = xmlDoc.CreateElement("NumberOfCopies")
            numberOfCopiesElement.InnerText = item.SubItems(3).Text
            ticketElement.AppendChild(numberOfCopiesElement)

            Dim totalElement As XmlElement = xmlDoc.CreateElement("Total")
            totalElement.InnerText = item.SubItems(5).Text
            ticketElement.AppendChild(totalElement)

            rootElement.AppendChild(ticketElement)
        Next

        ' Guardar el documento XML en el archivo
        xmlDoc.Save(filePath)

        MessageBox.Show("XML file exported successfully :D")


    End Sub
End Class