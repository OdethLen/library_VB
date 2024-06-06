<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Menu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        PictureBox1 = New PictureBox()
        btnFrmBook = New FontAwesome.Sharp.IconButton()
        btnFrmComputer = New FontAwesome.Sharp.IconButton()
        btnExit = New FontAwesome.Sharp.IconButton()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(291, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(192, 181)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' btnFrmBook
        ' 
        btnFrmBook.BackColor = Color.White
        btnFrmBook.Font = New Font("NSimSun", 11.25F)
        btnFrmBook.IconChar = FontAwesome.Sharp.IconChar.None
        btnFrmBook.IconColor = Color.Black
        btnFrmBook.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnFrmBook.Location = New Point(300, 221)
        btnFrmBook.Name = "btnFrmBook"
        btnFrmBook.Size = New Size(173, 34)
        btnFrmBook.TabIndex = 2
        btnFrmBook.Text = "Book"
        btnFrmBook.UseVisualStyleBackColor = False
        ' 
        ' btnFrmComputer
        ' 
        btnFrmComputer.BackColor = Color.White
        btnFrmComputer.Font = New Font("NSimSun", 11.25F)
        btnFrmComputer.IconChar = FontAwesome.Sharp.IconChar.None
        btnFrmComputer.IconColor = Color.Black
        btnFrmComputer.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnFrmComputer.Location = New Point(300, 274)
        btnFrmComputer.Name = "btnFrmComputer"
        btnFrmComputer.Size = New Size(173, 34)
        btnFrmComputer.TabIndex = 3
        btnFrmComputer.Text = "Computer"
        btnFrmComputer.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.White
        btnExit.Font = New Font("NSimSun", 11.25F)
        btnExit.IconChar = FontAwesome.Sharp.IconChar.None
        btnExit.IconColor = Color.Black
        btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto
        btnExit.Location = New Point(300, 330)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(173, 34)
        btnExit.TabIndex = 4
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' Menu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkSeaGreen
        ClientSize = New Size(790, 389)
        Controls.Add(btnExit)
        Controls.Add(btnFrmComputer)
        Controls.Add(btnFrmBook)
        Controls.Add(PictureBox1)
        Name = "Menu"
        Text = "Menu"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Private WithEvents btnFrmBook As FontAwesome.Sharp.IconButton
    Private WithEvents btnFrmComputer As FontAwesome.Sharp.IconButton
    Private WithEvents btnExit As FontAwesome.Sharp.IconButton

End Class
