Public Class frmMain

    Private Sub frmMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnRoll_Click(sender As System.Object, e As System.EventArgs) Handles btnRoll.Click
        Dim low As Integer = 1
        Dim high As Integer = 6
        Dim die1 As Integer
        Dim die2 As Integer
        Dim total As Integer

        die1 = Math.Floor((high - low + 1) * Rnd() + low)
        die2 = Math.Floor((high - low + 1) * Rnd() + low)
        total = die1 + die2

        Select Case die1
            Case 1
                imgDie1.Image = My.Resources.die1
            Case 2
                imgDie1.Image = My.Resources.die2
            Case 3
                imgDie1.Image = My.Resources.die3
            Case 4
                imgDie1.Image = My.Resources.die4
            Case 5
                imgDie1.Image = My.Resources.die5
            Case Else
                imgDie1.Image = My.Resources.die6
        End Select

        Select Case die2
            Case 1
                imgDie2.Image = My.Resources.die1
            Case 2
                imgDie2.Image = My.Resources.die2
            Case 3
                imgDie2.Image = My.Resources.die3
            Case 4
                imgDie2.Image = My.Resources.die4
            Case 5
                imgDie2.Image = My.Resources.die5
            Case Else
                imgDie2.Image = My.Resources.die6
        End Select

    End Sub



End Class
