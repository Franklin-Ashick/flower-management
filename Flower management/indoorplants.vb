Imports System.Data.SqlClient
Public Class indoorplants
    Dim con As New SqlConnection
    Dim com As SqlCommand
    Dim str As String
    Dim x As Integer
    Private Sub indoorplants_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Flower management\Flower management\flowers.mdf;Integrated Security=True")
    End Sub

    Private Sub jade_Click(sender As Object, e As EventArgs) Handles jade.Click
        Dim quantity As String
        quantity = Microsoft.VisualBasic.InputBox("Enter The Quantity Required" & vbCrLf & "Price Of The Product is 100", "To Flower Cart", "Enter here")
        If (quantity = "Enter here" OrElse quantity = "") Then
            MessageBox.Show("Try Again!!")
        Else
            x = 100 * quantity
            con.Open()
            str = "insert into cart(quantity,product,price,amt) values('" & quantity & "','Jade','100','" & x & "')"
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            MsgBox(quantity + " Items Added To Cart Successfully..")
            con.Close()
        End If
    End Sub
    Private Sub Bonsai_Click(sender As Object, e As EventArgs) Handles Bonsai.Click
        Dim quantity As String
        quantity = Microsoft.VisualBasic.InputBox("Enter The Quantity Required" & vbCrLf & "Price Of The Product is 200 ", "To Flower Cart", "Enter here")
        If (quantity = "Enter here" OrElse quantity = "") Then
            MessageBox.Show("Try Again!!")
        Else
            x = 200 * quantity
            con.Open()
            str = "insert into cart(quantity,product,price,amt) values('" & quantity & "','Bonsai','200','" & x & "')"
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            MsgBox(quantity + " Items Added To Cart Successfully..")
            con.Close()
        End If
    End Sub
    Private Sub Rubber_plant_Click(sender As Object, e As EventArgs) Handles Rubber_plant.Click
        Dim quantity As String
        quantity = Microsoft.VisualBasic.InputBox("Enter The Quantity Required" & vbCrLf & "Price Of The Product is 250 ", "To Flower Cart", "Enter here")
        If (quantity = "Enter here" OrElse quantity = "") Then
            MessageBox.Show("Try Again!!")
        Else
            x = 250 * quantity
            con.Open()
            str = "insert into cart(quantity,product,price,amt) values('" & quantity & "','Rubber Plant','250','" & x & "')"
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            MsgBox(quantity + " Items Added To Cart Successfully..")
            con.Close()
        End If
    End Sub
    Private Sub cactus_Click(sender As Object, e As EventArgs) Handles cactus.Click
        Dim quantity As String
        quantity = Microsoft.VisualBasic.InputBox("Enter The Quantity Required" & vbCrLf & "Price Of The Product is 300 ", "To Flower Cart", "Enter here")
        If (quantity = "Enter here" OrElse quantity = "") Then
            MessageBox.Show("Try Again!!")
        Else
            x = 300 * quantity
            con.Open()
            str = "insert into cart(quantity,product,price,amt) values('" & quantity & "','Cactus','300','" & x & "')"
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            MsgBox(quantity + " Items Added To Cart Successfully..")
            con.Close()
        End If
    End Sub
    Private Sub goldenpothos_Click(sender As Object, e As EventArgs) Handles goldenpothos.Click
        Dim quantity As String
        quantity = Microsoft.VisualBasic.InputBox("Enter The Quantity Required" & vbCrLf & "Price Of The Product is 400", "To Flower Cart", "Enter here")
        If (quantity = "Enter here" OrElse quantity = "") Then
            MessageBox.Show("Try Again!!")
        Else
            x = 400 * quantity
            con.Open()
            str = "insert into cart(quantity,product,price,amt) values('" & quantity & "','Golden Pothos',400,'" & x & "')"
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
End Class


