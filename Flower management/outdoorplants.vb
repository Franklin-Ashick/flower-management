Imports System.Data.SqlClient
Public Class outdoorplants
    Dim con As New SqlConnection
    Dim com As SqlCommand
    Dim str As String
    Dim x As Integer

    Private Sub outdoorplants_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Flower management\Flower management\flowers.mdf;Integrated Security=True")
    End Sub

    Private Sub onion_Click(sender As Object, e As EventArgs) Handles onion.Click
        Dim quantity As String
        quantity = Microsoft.VisualBasic.InputBox("Enter The Quantity Required" & vbCrLf & "Price Of The Product is 20", "To Flower Cart", "Enter here")
        If (quantity = "Enter here" OrElse quantity = "") Then
            MessageBox.Show("Try Again!!")
        Else
            x = 20 * quantity
            con.Open()
            str = "insert into cart(quantity,product,price,amt) values('" & quantity & "','Onion','20','" & x & "')"
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            MsgBox(quantity + " Items Added To Cart Successfully..")
            con.Close()
        End If
    End Sub
    Private Sub radish_Click(sender As Object, e As EventArgs) Handles radish.Click
        Dim quantity As String
        quantity = Microsoft.VisualBasic.InputBox("Enter The Quantity Required" & vbCrLf & "Price Of The Product is 30 ", "To Flower Cart", "Enter here")
        If (quantity = "Enter here" OrElse quantity = "") Then
            MessageBox.Show("Try Again!!")
        Else
            x = 30 * quantity
            con.Open()
            str = "insert into cart(quantity,product,price,amt) values('" & quantity & "','Radish','30','" & x & "')"
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            MsgBox(quantity + " Items Added To Cart Successfully..")
            con.Close()
        End If
    End Sub
    Private Sub carrot_Click(sender As Object, e As EventArgs) Handles carrot.Click
        Dim quantity As String
        quantity = Microsoft.VisualBasic.InputBox("Enter The Quantity Required" & vbCrLf & "Price Of The Product is 50 ", "To Flower Cart", "Enter here")
        If (quantity = "Enter here" OrElse quantity = "") Then
            MessageBox.Show("Try Again!!")
        Else
            x = 50 * quantity
            con.Open()
            str = "insert into cart(quantity,product,price,amt) values('" & quantity & "','Carrot','50','" & x & "')"
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            MsgBox(quantity + " Items Added To Cart Successfully..")
            con.Close()
        End If
    End Sub
    Private Sub pumkin_Click(sender As Object, e As EventArgs) Handles pumkin.Click
        Dim quantity As String
        quantity = Microsoft.VisualBasic.InputBox("Enter The Quantity Required" & vbCrLf & "Price Of The Product is 45 ", "To Flower Cart", "Enter here")
        If (quantity = "Enter here" OrElse quantity = "") Then
            MessageBox.Show("Try Again!!")
        Else
            x = 45 * quantity
            con.Open()
            str = "insert into cart(quantity,product,price,amt) values('" & quantity & "','Pumkin','45','" & x & "')"
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            MsgBox(quantity + " Items Added To Cart Successfully..")
            con.Close()
        End If
    End Sub
    Private Sub tomato_Click(sender As Object, e As EventArgs) Handles tomato.Click
        Dim quantity As String
        quantity = Microsoft.VisualBasic.InputBox("Enter The Quantity Required" & vbCrLf & "Price Of The Product is 30 ", "To Flower Cart", "Enter here")
        If (quantity = "Enter here" OrElse quantity = "") Then
            MessageBox.Show("Try Again!!")
        Else
            x = 30 * quantity
            con.Open()
            str = "insert into cart(quantity,product,price,amt) values('" & quantity & "','Pumkin','30','" & x & "')"
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            MsgBox(quantity + " Items Added To Cart Successfully..")
            con.Close()
        End If
    End Sub
End Class