Imports System.ComponentModel
Imports System.IO
Public Class SelectFileDialogvb
    ' Dim mainForm As Form1

    Private Sub SelectFileDialogvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            IO.Directory.CreateDirectory(Application.StartupPath & "\3D_Models")
        Catch ex As Exception

        End Try
        refreshList()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub SelectFileDialogvb_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Form1.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles selectFileBtn.Click
        If ListView1.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select a file!", "Select 3D Model", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Exit Sub
        End If
        Form1.Enabled = True

        Form1.filePath = "3D_Models\" & ListView1.SelectedItems(0).Text
        Form1.TextBox1.Text = ListView1.SelectedItems(0).Text
        Form1.TextBox1.BackColor = Color.LightGreen
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        refreshList()
    End Sub

    Private Sub refreshList()
        ListView1.Items.Clear()
        Dim ext = New List(Of String) From {
        ".obj",
        ".ply",
        ".dxf",
        ".xgl",
        ".pov",
        ".brep",
        ".ply",
        ".jot",
        ".off"
    }
        Dim myFiles = Directory.GetFiles(Application.StartupPath & "\3D_Models", "*.*", SearchOption.TopDirectoryOnly).Where(Function(s) ext.Contains(Path.GetExtension(s)))

        For Each i In myFiles
            i = i.Substring(i.LastIndexOf("\") + 1)

            ListView1.Items.Add(i, ImageList1.Images.Count() - 1)
        Next
    End Sub
End Class