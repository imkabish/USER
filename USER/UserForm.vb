Public Class UserForm
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Home_Click(sender As Object, e As EventArgs) Handles Home.Click
        Panel4.Height = Home.Height
        Panel4.Top = Home.Top
    End Sub

    Private Sub Auction_Click(sender As Object, e As EventArgs) Handles Auction.Click
        Panel4.Height = Auction.Height
        Panel4.Top = Auction.Top
    End Sub

    Private Sub MyActivity_Click(sender As Object, e As EventArgs) Handles MyActivity.Click
        Panel4.Height = MyActivity.Height
        Panel4.Top = MyActivity.Top
    End Sub

    Private Sub Settings_Click(sender As Object, e As EventArgs) Handles Settings.Click
        Panel4.Height = Settings.Height
        Panel4.Top = Settings.Top
    End Sub
End Class
