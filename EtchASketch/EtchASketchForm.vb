'Christopher Pickens
'RCET0265
'Spring 2023
'EtchASketch
'https://github.com/Pickchr2/EtchASketch.git

Option Explicit On
Option Strict On

Public Class EtchASketchForm
    Dim currentColor As Color

    Sub drawSinWave()
        Dim oldColor As Color = Me.currentColor
        Me.currentColor = Color.Red

        Dim vmax# = ((EtchASketchPictureBox.Height - 5) \ 2)
        Dim yOffset# = vmax
        Dim lastX% = -1, lastY% = CInt(yOffset), currentY%, currentX%
        Dim angle#

        For x = 0 To CInt(EtchASketchPictureBox.Width) Step EtchASketchPictureBox.Width / 360
            angle = (Math.PI / 180) * x
            currentY = CInt(-1 * vmax * Math.Sin(angle) + yOffset)
            currentX = CInt(x * EtchASketchPictureBox.Width / 360)
            DrawLineSegment(lastX, lastY, currentX, currentY)
            lastX = currentX
            lastY = currentY
        Next
        Me.currentColor = oldColor
    End Sub

    Sub ClearForm()
        Dim clearResponse As Integer
        Dim offset As Integer = 25

        clearResponse = MsgBox("This action will clear what is Drawn...Are you sure you wish to clear the Etch-A-Sketch?", vbYesNo, "Clear the Etch-A-Sketch.")

        If clearResponse = vbYes Then
            For i = 1 To 10
                offset = offset * -1
                Me.Top += offset
                Me.Left += offset
                System.Threading.Thread.Sleep(100)
            Next
            EtchASketchPictureBox.Refresh()
        End If
    End Sub

    Sub UpdateColor()
        EtchASketchColorDialog.ShowDialog()
        Me.currentColor = EtchASketchColorDialog.Color
    End Sub

    Sub DrawLineSegment(x1%, y1%, x2%, y2%)
        Dim graphic As Graphics = EtchASketchPictureBox.CreateGraphics
        Dim myPen = New Pen(Me.currentColor, 5)

        graphic.DrawLine(myPen, x1, y1, x2, y2)

        myPen.Dispose()
        graphic.Dispose()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click, ExitToolStripMenuItem.Click
        Dim exitResponse As Integer

        exitResponse = MsgBox("Are you sure you wish to exit the Etch-A-Sketch?", vbYesNo, "Exit the Application.")

        If exitResponse = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click, ClearToolStripMenuItem.Click
        ClearForm()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("Click and drag your mouse to draw a picture. Click the select color button to choose color of your drawing." _
               & vbCrLf & "Click the draw waveforms button to display Sin, Cos, and Tan waveforms on the Etch-A-Sketch.", , "About Etch-A-Sketch    .")
    End Sub

    Private Sub EtchASketchPictureBox_MouseMove(sender As Object, e As MouseEventArgs) Handles EtchASketchPictureBox.MouseMove, EtchASketchPictureBox.MouseDown
        Static lastX%, lastY%
        Select Case e.Button.ToString
            Case "Left"
                DrawLineSegment(lastX, lastY, e.X, e.Y)
            Case "Middle"
                UpdateColor()
        End Select
        Me.Text = $"({e.X},{e.Y}) button: {e.Button.ToString} Color: {Me.currentColor.ToString}"
        lastX = e.X
        lastY = e.Y
    End Sub

    Private Sub EtchASketchForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        currentColor = Color.Black
    End Sub

    Private Sub SelectColorButton_Click(sender As Object, e As EventArgs) Handles SelectColorButton.Click, SelectColorToolStripMenuItem.Click
        UpdateColor()
    End Sub

    Private Sub DrawWaveformsButton_Click(sender As Object, e As EventArgs) Handles DrawWaveformsButton.Click, DrawWaveformsToolStripMenuItem.Click
        ClearForm()
        drawSinWave()
    End Sub
End Class
