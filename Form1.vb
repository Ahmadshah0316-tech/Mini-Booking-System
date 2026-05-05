Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim totalprice As Double
            Dim personprice As Double = Val(TextBox2.Text) * 100

            totalprice = Val(TextBox1.Text) + personprice
            TextBox3.Text = totalprice

            Dim change As Double
            change = Val(TextBox4.Text) - Val(TextBox3.Text)

            TextBox5.Text = change

        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Try
            Dim change As Double
            change = Val(TextBox4.Text) - Val(TextBox3.Text)

            TextBox5.Text = change

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With ComboBox1.Items
            .Add("Standard Room with TV and Electric fan (2 person)")
            .Add("Family Room with TV and Electrtic fan (6 persons)")
            .Add("Deluxe Room with TV and Aircondition (6 persons)")
        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ComboBox1.Text = "Select a Room"
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim iExit As DialogResult
        iExit = MessageBox.Show("Confirm if you want to exit", "close application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iExit = DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub
End Class
