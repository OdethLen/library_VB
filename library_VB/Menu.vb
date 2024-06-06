Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Public Class Menu

    Public Sub New()
        InitializeComponent()
        ShowWelcomeMessage()
    End Sub

    Private Sub btnFrmBook_Click(sender As Object, e As EventArgs) Handles btnFrmBook.Click
        Dim form As New FrmBook()
        form.Show()
        Me.Hide()
    End Sub

    ' Método estático 
    Public Shared Sub ShowWelcomeMessage()
        MessageBox.Show("Welcome!!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnFrmComputer_Click(sender As Object, e As EventArgs) Handles btnFrmComputer.Click
        Dim form As New FrmComputer()
        form.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub


End Class
