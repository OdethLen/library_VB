<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBook
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
        grupbox1 = New GroupBox()
        dtpEndDate = New DateTimePicker()
        Label7 = New Label()
        txtPublisher = New TextBox()
        Label6 = New Label()
        txtTitle = New TextBox()
        dtpDate = New DateTimePicker()
        txtAuthor = New TextBox()
        txtLastName = New TextBox()
        txtName = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        btnBack = New Button()
        btnOpentxt = New Button()
        btnExporttxt = New Button()
        btnAdd = New Button()
        lstvBookregister = New ListView()
        btnExcel = New Button()
        btnWord = New Button()
        btnDelete = New Button()
        ErrorProvider = New ErrorProvider(components)
        grupbox1.SuspendLayout()
        CType(ErrorProvider, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' grupbox1
        ' 
        grupbox1.Controls.Add(dtpEndDate)
        grupbox1.Controls.Add(Label7)
        grupbox1.Controls.Add(txtPublisher)
        grupbox1.Controls.Add(Label6)
        grupbox1.Controls.Add(txtTitle)
        grupbox1.Controls.Add(dtpDate)
        grupbox1.Controls.Add(txtAuthor)
        grupbox1.Controls.Add(txtLastName)
        grupbox1.Controls.Add(txtName)
        grupbox1.Controls.Add(Label5)
        grupbox1.Controls.Add(Label4)
        grupbox1.Controls.Add(Label3)
        grupbox1.Controls.Add(Label2)
        grupbox1.Controls.Add(Label1)
        grupbox1.Font = New Font("NSimSun", 11.25F)
        grupbox1.Location = New Point(28, 42)
        grupbox1.Name = "grupbox1"
        grupbox1.Size = New Size(628, 227)
        grupbox1.TabIndex = 2
        grupbox1.TabStop = False
        grupbox1.Text = "Computer Register"
        ' 
        ' dtpEndDate
        ' 
        dtpEndDate.Format = DateTimePickerFormat.Short
        dtpEndDate.Location = New Point(312, 174)
        dtpEndDate.Name = "dtpEndDate"
        dtpEndDate.Size = New Size(114, 25)
        dtpEndDate.TabIndex = 14
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(235, 181)
        Label7.Name = "Label7"
        Label7.Size = New Size(71, 15)
        Label7.TabIndex = 13
        Label7.Text = "End data"
        ' 
        ' txtPublisher
        ' 
        txtPublisher.Location = New Point(105, 123)
        txtPublisher.Name = "txtPublisher"
        txtPublisher.Size = New Size(144, 25)
        txtPublisher.TabIndex = 12
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(20, 133)
        Label6.Name = "Label6"
        Label6.Size = New Size(79, 15)
        Label6.TabIndex = 11
        Label6.Text = "Publisher"
        ' 
        ' txtTitle
        ' 
        txtTitle.Location = New Point(84, 76)
        txtTitle.Name = "txtTitle"
        txtTitle.Size = New Size(144, 25)
        txtTitle.TabIndex = 10
        ' 
        ' dtpDate
        ' 
        dtpDate.Format = DateTimePickerFormat.Short
        dtpDate.Location = New Point(84, 177)
        dtpDate.Name = "dtpDate"
        dtpDate.Size = New Size(114, 25)
        dtpDate.TabIndex = 9
        ' 
        ' txtAuthor
        ' 
        txtAuthor.Location = New Point(445, 76)
        txtAuthor.Name = "txtAuthor"
        txtAuthor.Size = New Size(144, 25)
        txtAuthor.TabIndex = 8
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
        Label4.Location = New Point(318, 86)
        Label4.Name = "Label4"
        Label4.Size = New Size(55, 15)
        Label4.TabIndex = 3
        Label4.Text = "Author"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(19, 184)
        Label3.Name = "Label3"
        Label3.Size = New Size(39, 15)
        Label3.TabIndex = 2
        Label3.Text = "Date"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(20, 86)
        Label2.Name = "Label2"
        Label2.Size = New Size(47, 15)
        Label2.TabIndex = 1
        Label2.Text = "Title"
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
        ' btnBack
        ' 
        btnBack.Font = New Font("NSimSun", 11.25F)
        btnBack.Location = New Point(12, 12)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(61, 23)
        btnBack.TabIndex = 18
        btnBack.Text = "<--"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' btnOpentxt
        ' 
        btnOpentxt.Font = New Font("NSimSun", 11.25F)
        btnOpentxt.Location = New Point(748, 155)
        btnOpentxt.Name = "btnOpentxt"
        btnOpentxt.Size = New Size(109, 23)
        btnOpentxt.TabIndex = 21
        btnOpentxt.Text = "Open Txt"
        btnOpentxt.UseVisualStyleBackColor = True
        ' 
        ' btnExporttxt
        ' 
        btnExporttxt.Font = New Font("NSimSun", 11.25F)
        btnExporttxt.Location = New Point(748, 128)
        btnExporttxt.Name = "btnExporttxt"
        btnExporttxt.Size = New Size(109, 23)
        btnExporttxt.TabIndex = 20
        btnExporttxt.Text = "Export txt"
        btnExporttxt.UseVisualStyleBackColor = True
        ' 
        ' btnAdd
        ' 
        btnAdd.Font = New Font("NSimSun", 11.25F)
        btnAdd.Location = New Point(748, 99)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(109, 23)
        btnAdd.TabIndex = 19
        btnAdd.Text = "ADD"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' lstvBookregister
        ' 
        lstvBookregister.Location = New Point(47, 295)
        lstvBookregister.Name = "lstvBookregister"
        lstvBookregister.Size = New Size(642, 263)
        lstvBookregister.TabIndex = 22
        lstvBookregister.UseCompatibleStateImageBehavior = False
        ' 
        ' btnExcel
        ' 
        btnExcel.Font = New Font("NSimSun", 11.25F)
        btnExcel.Location = New Point(800, 401)
        btnExcel.Name = "btnExcel"
        btnExcel.Size = New Size(101, 23)
        btnExcel.TabIndex = 25
        btnExcel.Text = "Excel"
        btnExcel.UseVisualStyleBackColor = True
        ' 
        ' btnWord
        ' 
        btnWord.Font = New Font("NSimSun", 11.25F)
        btnWord.Location = New Point(800, 352)
        btnWord.Name = "btnWord"
        btnWord.Size = New Size(101, 23)
        btnWord.TabIndex = 24
        btnWord.Text = "Word"
        btnWord.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Font = New Font("NSimSun", 11.25F)
        btnDelete.Location = New Point(800, 295)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(101, 23)
        btnDelete.TabIndex = 23
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' ErrorProvider
        ' 
        ErrorProvider.ContainerControl = Me
        ' 
        ' FrmBook
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(966, 600)
        Controls.Add(btnExcel)
        Controls.Add(btnWord)
        Controls.Add(btnDelete)
        Controls.Add(lstvBookregister)
        Controls.Add(btnOpentxt)
        Controls.Add(btnExporttxt)
        Controls.Add(btnAdd)
        Controls.Add(btnBack)
        Controls.Add(grupbox1)
        Name = "FrmBook"
        Text = "FrmBook"
        grupbox1.ResumeLayout(False)
        grupbox1.PerformLayout()
        CType(ErrorProvider, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents grupbox1 As GroupBox
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents dtpEndDate As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPublisher As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents btnOpentxt As Button
    Friend WithEvents btnExporttxt As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents lstvBookregister As ListView
    Friend WithEvents btnExcel As Button
    Friend WithEvents btnWord As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents ErrorProvider As ErrorProvider
End Class
