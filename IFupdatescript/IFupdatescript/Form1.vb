Imports System
Imports System.ComponentModel
Imports System.IO

Public Class frmMain

    Public finalRelease As String = ""

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            tbFolderLocation.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click

        lblProgress.Text = "Writing updatescript.ini file"

        Dim userName As String
        Dim slashLoc As Integer
        Dim usersName As String

        userName = My.User.Name
        slashLoc = InStr(userName, "\")
        usersName = Mid(userName, slashLoc + 1)

        ' Make a reference to a directory.
        Dim di As New DirectoryInfo(tbFolderLocation.Text)
        ' Get a reference to each file in that directory.
        Dim fiArr As FileInfo() = di.GetFiles()
        ' Display the names of the files.
        Dim fri As FileInfo
        Dim strFile As String = "c:\Users\" & usersName & "\Desktop\updatescript.ini"
        Dim fileExists As Boolean = File.Exists(strFile)

        Using sw As New StreamWriter(File.Open(strFile, FileMode.OpenOrCreate))

            sw.WriteLine("releases{")

            For i As Integer = 0 To lbVersions.Items.Count - 1
                sw.WriteLine(lbVersions.Items(i))
            Next
            sw.WriteLine("[...]")
            sw.WriteLine("}")

            For j As Integer = 0 To lbVersions.Items.Count - 2
                sw.WriteLine("release:" & lbVersions.Items(j) & "{")
                sw.WriteLine("}")
            Next

            For k As Integer = 0 To lbVersions.Items.Count - 1
                finalRelease = lbVersions.Items(k)
            Next

            sw.WriteLine("release:" & finalRelease & "{")

            For Each fri In fiArr
                sw.WriteLine("DownloadFile:" & fri.Name & "," & TextBox1.Text)
            Next fri

            sw.WriteLine("}")

            sw.Flush()

        End Using

        lblProgress.Text = "Finished writing updatescript.ini."

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        lbVersions.Items.Add(tbVersion.Text)

    End Sub

End Class
