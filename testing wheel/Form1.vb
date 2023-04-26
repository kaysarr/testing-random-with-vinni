Public Class Form1

    Dim randGen As New Random
    Dim word As String
    Dim timer As Integer = 0
    Dim amount As Integer



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        word = randGen.Next(0, 24)

        timer += 1


        If timer = 5 Then
            lblWords.Text = lstInfo.Items(word)
        ElseIf timer = 10 Then
            lblWords.Text = lstInfo.Items(word)
        ElseIf timer = 15 Then
            lblWords.Text = lstInfo.Items(word)
        ElseIf timer = 20 Then
            lblWords.Text = lstInfo.Items(word)
        ElseIf timer = 25 Then
            lblWords.Text = lstInfo.Items(word)
        ElseIf timer = 30 Then
            timer = 0
        End If



    End Sub

    Private Sub randomizer() Handles btnRandom.Click




    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstInfo.Hide()
    End Sub

    Private Sub btnRandom_Click(sender As Object, e As EventArgs) Handles btnRandom.Click
        Timer1.Enabled = True

    End Sub
    Private Sub lblWords_Click(sender As Object, e As EventArgs) Handles lblWords.Click

    End Sub
End Class
