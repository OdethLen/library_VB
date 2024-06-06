<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmComputer
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        btnOpentxt = New Button()
        btnExporttxt = New Button()
        btnAdd = New Button()
        dtpDate = New DateTimePicker()
        cboboxComputernumber = New ComboBox()
        txtPrintNumber = New TextBox()
        txtLastName = New TextBox()
        txtName = New TextBox()
        lblTotal = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        lstvComputerregsiter = New ListView()
        btnDelete = New Button()
        btnWord = New Button()
        btnExcel = New Button()
        btnXml = New Button()
        ErrorProvider = New ErrorProvider(components)
        btnBack = New Button()
        GroupBox1.SuspendLayout()
        CType(ErrorProvider, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(20, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 15)
        Label1.TabIndex = 0
        Label1.Text = "Name"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnOpentxt)
        GroupBox1.Controls.Add(btnExporttxt)
        GroupBox1.Controls.Add(btnAdd)
        GroupBox1.Controls.Add(dtpDate)
        GroupBox1.Controls.Add(cboboxComputernumber)
        GroupBox1.Controls.Add(txtPrintNumber)
        GroupBox1.Controls.Add(txtLastName)
        GroupBox1.Controls.Add(txtName)
        GroupBox1.Controls.Add(lblTotal)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Font = New Font("NSimSun", 11.25F)
        GroupBox1.Location = New Point(12, 42)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(792, 207)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Computer Register"
        ' 
        ' btnOpentxt
        ' 
        btnOpentxt.Location = New Point(641, 121)
        btnOpentxt.Name = "btnOpentxt"
        btnOpentxt.Size = New Size(109, 23)
        btnOpentxt.TabIndex = 12
        btnOpentxt.Text = "Open Txt"
        btnOpentxt.UseVisualStyleBackColor = True
        ' 
        ' btnExporttxt
        ' 
        btnExporttxt.Location = New Point(641, 94)
        btnExporttxt.Name = "btnExporttxt"
        btnExporttxt.Size = New Size(109, 23)
        btnExporttxt.TabIndex = 11
        btnExporttxt.Text = "Export txt"
        btnExporttxt.UseVisualStyleBackColor = True
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(641, 65)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(109, 23)
        btnAdd.TabIndex = 10
        btnAdd.Text = "ADD"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' dtpDate
        ' 
        dtpDate.Format = DateTimePickerFormat.Short
        dtpDate.Location = New Point(85, 150)
        dtpDate.Name = "dtpDate"
        dtpDate.Size = New Size(114, 25)
        dtpDate.TabIndex = 9
        ' 
        ' cboboxComputernumber
        ' 
        cboboxComputernumber.FormattingEnabled = True
        cboboxComputernumber.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        cboboxComputernumber.Location = New Point(164, 92)
        cboboxComputernumber.Name = "cboboxComputernumber"
        cboboxComputernumber.Size = New Size(121, 23)
        cboboxComputernumber.TabIndex = 2
        ' 
        ' txtPrintNumber
        ' 
        txtPrintNumber.Location = New Point(445, 92)
        txtPrintNumber.Name = "txtPrintNumber"
        txtPrintNumber.Size = New Size(144, 25)
        txtPrintNumber.TabIndex = 8
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(445, 37)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(144, 25)
        txtLastName.TabIndex = 7
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(84, 37)
        txtName.Name = "txtName"
        txtName.Size = New Size(144, 25)
        txtName.TabIndex = 6
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Location = New Point(445, 157)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(31, 15)
        lblTotal.TabIndex = 5
        lblTotal.Text = "..."
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(318, 40)
        Label5.Name = "Label5"
        Label5.Size = New Size(79, 15)
        Label5.TabIndex = 4
        Label5.Text = "Last name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(318, 95)
        Label4.Name = "Label4"
        Label4.Size = New Size(103, 15)
        Label4.TabIndex = 3
        Label4.Text = "Print number"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(20, 157)
        Label3.Name = "Label3"
        Label3.Size = New Size(39, 15)
        Label3.TabIndex = 2
        Label3.Text = "Date"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(20, 95)
        Label2.Name = "Label2"
        Label2.Size = New Size(127, 15)
        Label2.TabIndex = 1
        Label2.Text = "Computer number"
        ' 
        ' lstvComputerregsiter
        ' 
        lstvComputerregsiter.Location = New Point(32, 284)
        lstvComputerregsiter.Name = "lstvComputerregsiter"
        lstvComputerregsiter.Size = New Size(642, 263)
        lstvComputerregsiter.TabIndex = 2
        lstvComputerregsiter.UseCompatibleStateImageBehavior = False
        ' 
        ' btnDelete
        ' 
        btnDelete.Font = New Font("NSimSun", 11.25F)
        btnDelete.Location = New Point(703, 272)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(101, 23)
        btnDelete.TabIndex = 13
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnWord
        ' 
        btnWord.Font = New Font("NSimSun", 11.25F)
        btnWord.Location = New Point(703, 329)
        btnWord.Name = "btnWord"
        btnWord.Size = New Size(101, 23)
        btnWord.TabIndex = 14
        btnWord.Text = "Word"
        btnWord.UseVisualStyleBackColor = True
        ' 
        ' btnExcel
        ' 
        btnExcel.Font = New Font("NSimSun", 11.25F)
        btnExcel.Location = New Point(703, 378)
        btnExcel.Name = "btnExcel"
        btnExcel.Size = New Size(101, 23)
        btnExcel.TabIndex = 15
        btnExcel.Text = "Excel"
        btnExcel.UseVisualStyleBackColor = True
        ' 
        ' btnXml
        ' 
        btnXml.Font = New Font("NSimSun", 11.25F)
        btnXml.Location = New Point(703, 508)
        btnXml.Name = "btnXml"
        btnXml.Size = New Size(101, 23)
        btnXml.TabIndex = 16
        btnXml.Text = "Xml"
        btnXml.UseVisualStyleBackColor = True
        ' 
        ' ErrorProvider
        ' 
        ErrorProvider.ContainerControl = Me
        ' 
        ' btnBack
        ' 
        btnBack.Font = New Font("NSimSun", 11.25F)
        btnBack.Location = New Point(12, 12)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(61, 23)
        btnBack.TabIndex = 17
        btnBack.Text = "<--"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' FrmComputer
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(827, 599)
        Controls.Add(btnBack)
        Controls.Add(btnXml)
        Controls.Add(btnExcel)
        Controls.Add(btnWord)
        Controls.Add(btnDelete)
        Controls.Add(lstvComputerregsiter)
        Controls.Add(GroupBox1)
        Name = "FrmComputer"
        Text = "FrmComputer"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(ErrorProvider, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents cboboxComputernumber As ComboBox
    Friend WithEvents txtPrintNumber As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lstvComputerregsiter As ListView
    Friend WithEvents btnOpentxt As Button
    Friend WithEvents btnExporttxt As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnWord As Button
    Friend WithEvents btnExcel As Button
    Friend WithEvents btnXml As Button
    Friend WithEvents ErrorProvider As ErrorProvider
    Friend WithEvents btnBack As Button
End Class
