Public Class frmSettings
    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblImageFolder.Text = My.Settings.ImageFolder
        ckOpenImageFolder.Checked = My.Settings.mboolConfirmImagebyOpeningFolder


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        My.Settings.ImageFolder = lblImageFolder.Text
        My.Settings.mboolConfirmImagebyOpeningFolder = ckOpenImageFolder.Checked
        My.Settings.Save()
        Me.Close()

    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim ofd As New FolderBrowserDialog
        With ofd
            If .ShowDialog() = DialogResult.OK Then
                If .SelectedPath <> "" Then
                    lblImageFolder.Text = ofd.SelectedPath
                End If
            End If
        End With
    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        If My.Settings.ImageFolder <> "" Then
            Try
                System.Diagnostics.Process.Start(My.Settings.ImageFolder)
            Catch ex As Exception

            End Try

        End If
    End Sub
End Class