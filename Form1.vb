Public Class btnresult
    Private Sub btntotal_Click_1(sender As Object, e As EventArgs) Handles btntotal.Click
        Dim Maths As Double
        Dim English As Double
        Dim Science As Double
        Dim Average As Double
        Dim social As Double

        If txtmaths.Text = "" Then
            MsgBox("Invalid maths value")
        Else

            Maths = Val(txtmaths.Text)
            English = Val(txtenglish.Text)
            Science = Val(txtscience.Text)
            social = Val(txtsocial.Text)
            Average = (Maths + English + Science + social)
            lblresult.Text = Average
        End If

    End Sub

    Private Sub btnaverage_Click(sender As Object, e As EventArgs) Handles btnaverage.Click
        Dim Maths As Double
        Dim English As Double
        Dim Science As Double
        Dim Average As Double
        Dim social As Double


        Maths = Val(txtmaths.Text)
        English = Val(txtenglish.Text)
        Science = Val(txtscience.Text)
        social = Val(txtsocial.Text)
        Average = (Maths + English + Science + social) / 4
        lblresult.Text = Average


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim totalmarks As Integer
        totalmarks = (txtmaths.Text)
        Dim n As Integer
        n = Val(lblresult.Text)
        Dim gafur As Boolean
        gafur = False
        For i = 2 To (n - 1)
            If n Mod i = 0 Then
                gafur = True
            End If
            Exit For
        Next
        If gafur = False Then
            Label1.Text = ("It is a Prime number")
        Else
            Label1.Text = ("It is not a Prime number")

        End If

        Dim Maths As Double
        Dim English As Double
        Dim Science As Double
        Dim social As Double
        Dim Average As Double


        Maths = Val(txtmaths.Text)
        English = Val(txtenglish.Text)
        Science = Val(txtscience.Text)
        social = Val(txtsocial.Text)

        Average = (Maths + English + Science + social) / 4

        If Average >= 80 Then
            MsgBox("A")
        ElseIf Average >= 70 Then
            MsgBox("B")
        ElseIf Average >= 60 Then
            MsgBox("C")
        ElseIf Average >= 50 Then
            MsgBox("D")
        ElseIf Average <= 40 Then
            MsgBox("F")



        End If


    End Sub

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click

        txtmaths.Clear()
        txtenglish.Clear()
        txtscience.Clear()
        lblresult.Text = ("")
        Label1.Text = ("")
        txtsocial.Clear()











    End Sub

    Private Sub btnresult_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
