'Christopher Pickens
'RCET0265
'Spring 2023
'EtchASketch
'https://github.com/Pickchr2/EtchASketch.git

Option Explicit On
Option Strict On

Public Class EtchASketchForm
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click, ExitToolStripMenuItem.Click
        Dim exitResponse As Integer

        exitResponse = MsgBox("Are you sure you wish to exit the Etch-A-Sketch?", vbYesNo, "Exit the Application.")

        If exitResponse = vbYes Then
            Me.Close()
        End If
    End Sub
End Class
