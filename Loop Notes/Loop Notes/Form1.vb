Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Add 1-5 to the ListBox the LONG WAY
        ListBox1.Items.Add(1)
        ListBox1.Items.Add(2)
        ListBox1.Items.Add(3)
        ListBox1.Items.Add(4)
        ListBox1.Items.Add(5)
    End Sub




    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Add 1-5 to the ListBox the LOOP WAY

        'Loops are used to automatically repeat code
        'Our loop will use the i variable to
        'count from 1 to 5
        Dim i As Integer

        For i = 1 To 5
            ListBox1.Items.Add(i)
        Next
    End Sub




    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Display -10 to 10
        Dim i As Integer

        For i = -10 To 10
            ListBox1.Items.Add(i)
        Next



    End Sub




    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim i As Integer

        'A step command can be used to make the loop
        'count differently
        'Step 2, means count up by 2s
        For i = 2 To 100 Step 2
            ListBox1.Items.Add(i)
        Next
    End Sub






    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'Display a NASA countdown from 10 to 1 in the ListBox
        'At the end, display "BLASTOFF!"
        Dim i As Integer

        For i = 10 To 1 Step -1
            ListBox1.Items.Add(i)
        Next
        ListBox1.Items.Add("Blastoff!")



    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        'DO WHILE loops can do the same things as for loops
        Dim i As Integer
        i = 1
        'DO WHILE loops repeat until the Boolean expression
        'is FALSE
        Do While i <= 5
            ListBox1.Items.Add(i)
            i = i + 1 'add 1 so that i moves closer to 5
        Loop

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'Display -10 to 10

        Dim i As Integer
        i = -10

        Do While i <= 10
            ListBox1.Items.Add(i)
            i = i + 1
        Loop


    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        'DO WHILE Loops can do more than count

        Dim r As New Random
        Dim secret As Integer
        secret = r.Next(1, 11)

        Dim guess As Integer
        'Loop while the player has NOT guessed correctly
        Do While guess <> secret
            'Ask the player to guess
            guess = InputBox("Enter your guess")
        Loop

        MsgBox("You got it right!")

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim userinput As String
        userinput = InputBox("Do you want to feel better?")

        Do While userinput = "Yes" Or userinput = "yes"
            MsgBox("You are great!!!") 'Boost user self-esteem
            'Ask again
            userinput = InputBox("Do you want to feel better?")
        Loop

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim r As New Random
        Dim mine, userinput As Integer

        mine = r.Next(1, 6)

        MsgBox("Welcome to Minesweeper!")
        MsgBox("There are 5 spaces. One has a mine.")
        MsgBox("Guess until you explode.")

        Do While userinput <> mine
            userinput = InputBox("Guess!")
        Loop

        MsgBox("Boom!")

    End Sub
End Class
