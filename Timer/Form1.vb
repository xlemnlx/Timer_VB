Public Class Form1

    Private Sub button_exit_Click(sender As Object, e As EventArgs) Handles button_exit.Click
        Me.Close()
    End Sub

    Private Sub button_start_Click(sender As Object, e As EventArgs) Handles button_start.Click
        If Timer1.Enabled = False Then
            Timer1.Enabled = True
        Else
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text = Label3.Text + 1
        If Label3.Text = "60" Then
            Label2.Text = Label2.Text + 1
            Label3.Text = "00"
        ElseIf Label2.Text = "60" Then
            Label1.Text = Label1.Text + 1
            Label2.Text = "00"
        ElseIf Label1.Text = "60" Then
            Label6.Text = Label6.Text + 1
            Label1.Text = "00"
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = False
    End Sub

    Private Sub button_reset_Click(sender As Object, e As EventArgs) Handles button_reset.Click
        Label3.Text = "00"
        Label2.Text = "00"
        Label1.Text = "00"
        Label6.Text = "00"
    End Sub
End Class
