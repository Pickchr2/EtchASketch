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

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        Dim clearResponse As Integer

        clearResponse = MsgBox("Are you sure you wish to clear the Etch-A-Sketch?", vbYesNo, "Clear the Etch-A-Sketch.")

        If clearResponse = vbYes Then
            EtchASketchPictureBox.Refresh()
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("Click and drag your mouse to draw a picture. Click the select color button to choose color of your drawing." _
               & vbCrLf & "Click the draw waveforms button to display Sin, Cos, and Tan waveforms on the Etch-O-Sketch.", , "About.")
    End Sub
End Class
