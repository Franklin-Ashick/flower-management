Imports System.Data.SqlClient
Public Class flowers_type
    Dim con As New SqlConnection
    Dim com As SqlCommand
    Dim str As String
    Dim x As Integer
    Private Sub flowers_type_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Flower management\Flower management\flowers.mdf;Integrated Security=True")
    End Sub

    Private Sub color_Click(sender As Object, e As EventArgs) Handles color.Click
        bycolor.Visible = True
        Bytype.Visible = False

    End Sub
    Private Sub type_Click(sender As Object, e As EventArgs) Handles type.Click
        bycolor.Visible = False
        Bytype.Visible = True
    End Sub



    Private Sub rose_Click(sender As Object, e As EventArgs) Handles rose.Click
        Dim quantity As String
        quantity = Microsoft.VisualBasic.InputBox("Enter The Quantity Required" & vbCrLf & "Price Of The Product is 10", "To Flower Cart", "Enter here")
        If (quantity = "Enter here" OrElse quantity = "") Then
            MessageBox.Show("Try Again!!")
        Else

            x = 10 * quantity
            con.Open()
            str = "insert into cart(quantity,product,price,amt) values('" & quantity & "','Rose','10','" & x & "')"
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            MsgBox(quantity + " Items Added To Cart Successfully..")
            con.Close()
        End If
    End Sub
    Private Sub lily_Click(sender As Object, e As EventArgs) Handles lily.Click
        Dim quantity As String
        quantity = Microsoft.VisualBasic.InputBox("Enter The Quantity Required" & vbCrLf & "Price Of The Product is 15", "To Flower Cart", "Enter here")
        If (quantity = "Enter here" OrElse quantity = "") Then
            MessageBox.Show("Try Again!!")
        Else

            x = 15 * quantity
            con.Open()
            str = "insert into cart(quantity,product,price,amt) values('" & quantity & "','Lily','15','" & x & "')"
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            MsgBox(quantity + " Items Added To Cart Successfully..")
            con.Close()
        End If
    End Sub
    Private Sub orchids_Click(sender As Object, e As EventArgs) Handles orchids.Click
        Dim quantity As String
        quantity = Microsoft.VisualBasic.InputBox("Enter The Quantity Required" & vbCrLf & "Price Of The Product is 20", "To Flower Cart", "Enter here")
        If (quantity = "Enter here" OrElse quantity = "") Then
            MessageBox.Show("Try Again!!")
        Else

            x = 20 * quantity
            con.Open()
            str = "insert into cart(quantity,product,price,amt) values('" & quantity & "','Orchids','20','" & x & "')"
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            MsgBox(quantity + " Items Added To Cart Successfully..")
            con.Close()
        End If
    End Sub
    Private Sub tulip_Click(sender As Object, e As EventArgs) Handles tulip.Click
        Dim quantity As String
        quantity = Microsoft.VisualBasic.InputBox("Enter The Quantity Required" & vbCrLf & "Price Of The Product is 5", "To Flower Cart", "Enter here")
        If (quantity = "Enter here" OrElse quantity = "") Then
            MessageBox.Show("Try Again!!")
        Else

            x = 5 * quantity
            con.Open()
            str = "insert into cart(quantity,product,price,amt) values('" & quantity & "','Tulip','5','" & x & "')"
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            MsgBox(quantity + " Items Added To Cart Successfully..")
            con.Close()
        End If
    End Sub
    Private Sub mixed_Click(sender As Object, e As EventArgs) Handles mixed.Click
        Dim quantity As String
        quantity = Microsoft.VisualBasic.InputBox("Enter The Quantity Required" & vbCrLf & "Price Of The Product is 50", "To Flower Cart", "Enter here")
        If (quantity = "Enter here" OrElse quantity = "") Then
            MessageBox.Show("Try Again!!")
        Else

            x = 50 * quantity
            con.Open()
            str = "insert into cart(quantity,product,price,amt) values('" & quantity & "','Mixxed Flowers','50','" & x & "')"
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            MsgBox(quantity + " Items Added To Cart Successfully..")
            con.Close()
        End If
    End Sub

    Private Sub red_Click(sender As Object, e As EventArgs) Handles red.Click
        Dim quantity As String
        quantity = Microsoft.VisualBasic.InputBox("Enter The Quantity Required" & vbCrLf & "Price Of The Product is 40", "To Flower Cart", "Enter here")
        If (quantity = "Enter here" OrElse quantity = "") Then
            MessageBox.Show("Try Again!!")
        Else

            x = 40 * quantity
            con.Open()
            str = "insert into cart(quantity,product,price,amt) values('" & quantity & "','Red Color','40','" & x & "')"
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            MsgBox(quantity + " Items Added To Cart Successfully..")
            con.Close()
        End If
    End Sub
    Private Sub pink_Click(sender As Object, e As EventArgs) Handles pink.Click
        Dim quantity As String
        quantity = Microsoft.VisualBasic.InputBox("Enter The Quantity Required" & vbCrLf & "Price Of The Product is 45", "To Flower Cart", "Enter here")
        If (quantity = "Enter here" OrElse quantity = "") Then
            MessageBox.Show("Try Again!!")
        Else

            x = 45 * quantity
            con.Open()
            str = "insert into cart(quantity,product,price,amt) values('" & quantity & "','Pink Color','45','" & x & "')"
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            MsgBox(quantity + " Items Added To Cart Successfully..")
            con.Close()
        End If
    End Sub
    Private Sub white_Click(sender As Object, e As EventArgs) Handles white.Click
        Dim quantity As String
        quantity = Microsoft.VisualBasic.InputBox("Enter The Quantity Required" & vbCrLf & "Price Of The Product is 60", "To Flower Cart", "Enter here")
        If (quantity = "Enter here" OrElse quantity = "") Then
            MessageBox.Show("Try Again!!")
        Else

            x = 60 * quantity
            con.Open()
            str = "insert into cart(quantity,product,price,amt) values('" & quantity & "','White Color','60','" & x & "')"
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            MsgBox(quantity + " Items Added To Cart Successfully..")
            con.Close()
        End If
    End Sub
    Private Sub purple_Click(sender As Object, e As EventArgs) Handles purple.Click
        Dim quantity As String
        quantity = Microsoft.VisualBasic.InputBox("Enter The Quantity Required" & vbCrLf & "Price Of The Product is 55 ", "To Flower Cart", "Enter here")
        If (quantity = "Enter here" OrElse quantity = "") Then
            MessageBox.Show("Try Again!!")
        Else

            x = 55 * quantity
            con.Open()
            str = "insert into cart(quantity,product,price,amt) values('" & quantity & "','Purple Color','55','" & x & "')"
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            MsgBox(quantity + " Items Added To Cart Successfully..")
            con.Close()
        End If
    End Sub
    Private Sub yellow_Click(sender As Object, e As EventArgs) Handles yellow.Click
        Dim quantity As String
        quantity = Microsoft.VisualBasic.InputBox("Enter The Quantity Required" & vbCrLf & "Price Of The Product is 70 ", "To Flower Cart", "Enter here")
        If (quantity = "Enter here" OrElse quantity = "") Then
            MessageBox.Show("Try Again!!")
        Else

            x = 70 * quantity
            con.Open()
            str = "insert into cart(quantity,product,price,amt) values('" & quantity & "','Yellow Color','70','" & x & "')"
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            MsgBox(quantity + " Items Added To Cart Successfully..")
            con.Close()
        End If
    End Sub
    Private Sub mixedcolor_Click(sender As Object, e As EventArgs) Handles mixedcolor.Click
        Dim quantity As String
        quantity = Microsoft.VisualBasic.InputBox("Enter The Quantity Required" & vbCrLf & "Price Of The Product is 100", "To Flower Cart", "Enter here")
        If (quantity = "Enter here" OrElse quantity = "") Then
            MessageBox.Show("Try Again!!")
        Else

            x = 100 * quantity
            con.Open()
            str = "insert into cart(quantity,product,price,amt) values('" & quantity & "','Mixed Flowers','100',,'" & x & "')"
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            MsgBox(quantity + " Items Added To Cart Successfully..")
            con.Close()
        End If
    End Sub


    Private Sub BunifuCustomLabel11_MouseDoubleClick(sender As Object, e As EventArgs) Handles BunifuCustomLabel11.Click
        Me.Hide()
        Homepage.Show()
    End Sub

    Private Sub Bytype_Paint(sender As Object, e As PaintEventArgs) Handles Bytype.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class