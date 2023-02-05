Imports System.Data.SqlClient

Public Class Homepage
    Dim con As New SqlConnection
    Dim com As SqlCommand
    Dim str As String
    Dim x As Integer
    Private Sub Homepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Flower management\Flower management\flowers.mdf;Integrated Security=True")
    End Sub
    Private Sub flowers_Click(sender As Object, e As EventArgs) Handles flowers.Click
        flowers_type.Show()
        Me.Hide()
    End Sub

    Private Sub plants_Click(sender As Object, e As EventArgs) Handles plants.Click
        bouquet.Visible = False
        plantss.Visible = True
        seedd.Visible = False
        accessor.Visible = False
        pott.Visible = False
    End Sub
    Private Sub bouquets_Click(sender As Object, e As EventArgs) Handles bouquets.Click

        bouquet.Visible = True
        plantss.Visible = False
        seedd.Visible = False
        accessor.Visible = False
        pott.Visible = False
    End Sub
    Private Sub pots_Click(sender As Object, e As EventArgs) Handles pots.Click

        bouquet.Visible = False
        plantss.Visible = False
        seedd.Visible = False
        accessor.Visible = False
        pott.Visible = True
    End Sub
    Private Sub seeds_Click(sender As Object, e As EventArgs) Handles seeds.Click

        bouquet.Visible = False
        plantss.Visible = False
        seedd.Visible = True
        accessor.Visible = False
        pott.Visible = False
    End Sub
    Private Sub accessories_Click(sender As Object, e As EventArgs) Handles accessories.Click

        bouquet.Visible = False
        plantss.Visible = False
        seedd.Visible = False
        accessor.Visible = True
        pott.Visible = False
    End Sub

    Private Sub indoor_plants_Click(sender As Object, e As EventArgs) Handles indoor_plants.Click
        indoorplants.Show()
    End Sub
    Private Sub outdoor_plants_Click(sender As Object, e As EventArgs) Handles outdoor_plants.Click
        outdoorplants.Show()
    End Sub

    Private Sub plants_fertilizers_Click(sender As Object, e As EventArgs) Handles plants_fertilizers.Click
        Dim quantity As String
        quantity = Microsoft.VisualBasic.InputBox("Enter The Quantity Required" & vbCrLf & "Price Of The Product is 200", "To Flower Cart", "Enter here")
        If (quantity = "Enter here" OrElse quantity = "") Then
            MessageBox.Show("Try Again!!")
        Else
            x = 200 * quantity
            con.Open()
            str = "insert into cart(quantity,product,price) values('" & quantity & "','Plant Fertilizers','" & x & "','200')"
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            MsgBox(quantity + " Items Added To Cart Successfully..")
            con.Close()
        End If
    End Sub
    Private Sub watering_cans_Click(sender As Object, e As EventArgs) Handles watering_cans.Click
        Dim quantity As String
        quantity = Microsoft.VisualBasic.InputBox("Enter The Quantity Required" & vbCrLf & "Price Of The Product is 150", "To Flower Cart", "Enter here")
        If (quantity = "Enter here" OrElse quantity = "") Then
            MessageBox.Show("Try Again!!")
        Else

            x = 150 * quantity
            con.Open()
            str = "insert into cart(quantity,product,amt,price) values('" & quantity & "','Watering Plants','" & x & "','150')"
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            MsgBox(quantity + " Items Added To Cart Successfully..")
            con.Close()
        End If
    End Sub
    Private Sub tools_Click(sender As Object, e As EventArgs) Handles tools.Click
        Dim quantity As String
        quantity = Microsoft.VisualBasic.InputBox("Enter The Quantity Required" & vbCrLf & "Price Of The Product is 50", "To Flower Cart", "Enter here")
        If (quantity = "Enter here" OrElse quantity = "") Then
            MessageBox.Show("Try Again!!")
        Else

            x = 50 * quantity
            con.Open()
            str = "insert into cart(quantity,product,amt,price) values('" & quantity & "','Tools','" & x & "','50')"
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            MsgBox(quantity + " Items Added To Cart Successfully..")
            con.Close()
        End If
    End Sub
    Private Sub vases_Click(sender As Object, e As EventArgs) Handles vases.Click
        Dim quantity As String
        quantity = Microsoft.VisualBasic.InputBox("Enter The Quantity Required" & vbCrLf & "Price Of The Product is 80", "To Flower Cart", "Enter here")
        If (quantity = "Enter here" OrElse quantity = "") Then
            MessageBox.Show("Try Again!!")
        Else

            x = 80 * quantity
            con.Open()
            str = "insert into cart(quantity,product,amt,price) values('" & quantity & "','Vases','" & x & "','80')"
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            MsgBox(quantity + " Items Added To Cart Successfully..")
            con.Close()
        End If
    End Sub
    Private Sub Ribbons_Click(sender As Object, e As EventArgs) Handles Ribbons.Click
        Dim quantity As String
        quantity = Microsoft.VisualBasic.InputBox("Enter The Quantity Required" & vbCrLf & "Price Of The Product is 10", "To Flower Cart", "Enter here")
        If (quantity = "Enter here" OrElse quantity = "") Then
            MessageBox.Show("Try Again!!")
        Else

            x = 10 * quantity
            con.Open()
            str = "insert into cart(quantity,product,amt,price) values('" & quantity & "','Ribbons','" & x & "','10')"
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            MsgBox(quantity + " Items Added To Cart Successfully..")
            con.Close()
        End If
    End Sub
    Private Sub artificial_plants_Click(sender As Object, e As EventArgs) Handles artificial_plants.Click
        Dim quantity As String
        quantity = Microsoft.VisualBasic.InputBox("Enter The Quantity Required" & vbCrLf & "Price Of The Product is 110", "To Flower Cart", "Enter here")
        If (quantity = "Enter here" OrElse quantity = "") Then
            MessageBox.Show("Try Again!!")
        Else
            x = 110 * quantity
            con.Open()
            str = "insert into cart(quantity,product,amt,price) values('" & quantity & "','Artificial Plants','" & x & "','110')"
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            MsgBox(quantity + " Items Added To Cart Successfully..")
            con.Close()
        End If
    End Sub
    Private Sub sweatpea_Click(sender As Object, e As EventArgs) Handles sweatpea.Click
        Dim quantity As String
        quantity = Microsoft.VisualBasic.InputBox("Enter The Quantity Required" & vbCrLf & "Price Of The Product is 160", "To Flower Cart", "Enter here")
        If (quantity = "Enter here" OrElse quantity = "") Then
            MessageBox.Show("Try Again!!")
        Else
            x = 160 * quantity
            con.Open()
            str = "insert into cart(quantity,product,amt,price) values('" & quantity & "','Flower Seeds','" & x & "','160')"
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            MsgBox(quantity + " Items Added To Cart Successfully..")
            con.Close()
        End If
    End Sub
    Private Sub marigold_Click(sender As Object, e As EventArgs) Handles marigold.Click
        Dim quantity As String
        quantity = Microsoft.VisualBasic.InputBox("Enter The Quantity Required" & vbCrLf & "Price Of The Product is 150", "To Flower Cart", "Enter here")
        If (quantity = "Enter here" OrElse quantity = "") Then
            MessageBox.Show("Try Again!!")
        Else

            x = 150 * quantity
            con.Open()
            str = "insert into cart(quantity,product,amt,price) values('" & quantity & "','Veg Seeds','" & x & "','150')"
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            MsgBox(quantity + " Items Added To Cart Successfully..")
            con.Close()
        End If
    End Sub
    Private Sub Hibiscus_Click(sender As Object, e As EventArgs) Handles Hibiscus.Click
        Dim quantity As String
        quantity = Microsoft.VisualBasic.InputBox("Enter The Quantity Required" & vbCrLf & "Price Of The Product is 100", "To Flower Cart", "Enter here")
        If (quantity = "Enter here" OrElse quantity = "") Then
            MessageBox.Show("Try Again!!")
        Else

            x = 100 * quantity
            con.Open()
            str = "insert into cart(quantity,product,amt,price) values('" & quantity & "','Veg Seeds','" & x & "','100')"
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            MsgBox(quantity + " Items Added To Cart Successfully..")
            con.Close()
        End If
    End Sub
    Private Sub Dahila_Click(sender As Object, e As EventArgs) Handles Dahila.Click
        Dim quantity As String
        quantity = Microsoft.VisualBasic.InputBox("Enter The Quantity Required" & vbCrLf & "Price Of The Product is 50", "To Flower Cart", "Enter here")
        If (quantity = "Enter here" OrElse quantity = "") Then
            MessageBox.Show("Try Again!!")
        Else

            x = 50 * quantity
            con.Open()
            str = "insert into cart(quantity,product,amt,price) values('" & quantity & "','Veg Seeds','" & x & "','50')"
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            MsgBox(quantity + " Items Added To Cart Successfully..")
            con.Close()
        End If
    End Sub
    Private Sub Mustard_Click(sender As Object, e As EventArgs) Handles Mustard.Click
        Dim quantity As String
        quantity = Microsoft.VisualBasic.InputBox("Enter The Quantity Required" & vbCrLf & "Price Of The Product is 25", "To Flower Cart", "Enter here")
        If (quantity = "Enter here" OrElse quantity = "") Then
            MessageBox.Show("Try Again!!")
        Else

            x = 25 * quantity
            con.Open()
            str = "insert into cart(quantity,product,amt,price) values('" & quantity & "','Veg Seeds','" & x & "','25')"
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            MsgBox(quantity + " Items Added To Cart Successfully..")
            con.Close()
        End If
    End Sub
    Private Sub balsam_Click(sender As Object, e As EventArgs) Handles balsam.Click
        Dim quantity As String
        quantity = Microsoft.VisualBasic.InputBox("Enter The Quantity Required" & vbCrLf & "Price Of The Product is 200", "To Flower Cart", "Enter here")
        If (quantity = "Enter here" OrElse quantity = "") Then
            MessageBox.Show("Try Again!!")
        Else
            x = 200 * quantity
            con.Open()
            str = "insert into cart(quantity,product,amt,price) values('" & quantity & "','Veg Seeds','" & x & "','200')"
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            MsgBox(quantity + " Items Added To Cart Successfully..")
            con.Close()
        End If

    End Sub
    Private Sub hangin_plants_Click(sender As Object, e As EventArgs) Handles hangin_plants.Click
        Dim quantity As String
        quantity = Microsoft.VisualBasic.InputBox("Enter The Quantity Required" & vbCrLf & "Price Of The Product is 300", "To Flower Cart", "Enter here")
        If (quantity = "Enter here" OrElse quantity = "") Then
            MessageBox.Show("Try Again!!")
        Else

            x = 300 * quantity
            con.Open()
            str = "insert into cart(quantity,product,amt,price) values('" & quantity & "','Hanging Plants','" & x & "','300')"
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            MsgBox(quantity + " Items Added To Cart Successfully..")
            con.Close()
        End If
    End Sub
    Private Sub plastic_pots_Click(sender As Object, e As EventArgs) Handles plastic_pots.Click
        Dim quantity As String
        quantity = Microsoft.VisualBasic.InputBox("Enter The Quantity Required" & vbCrLf & "Price Of The Product is 200", "To Flower Cart", "Enter here")
        If (quantity = "Enter here" OrElse quantity = "") Then
            MessageBox.Show("Try Again!!")
        Else

            x = 200 * quantity
            con.Open()
            str = "insert into cart(quantity,product,amt,price) values('" & quantity & "','Plastic Plants','" & x & "','200')"
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            MsgBox(quantity + " Items Added To Cart Successfully..")
            con.Close()
        End If
    End Sub
    Private Sub ceramic_pots_Click(sender As Object, e As EventArgs) Handles ceramic_pots.Click
        Dim quantity As String
        quantity = Microsoft.VisualBasic.InputBox("Enter The Quantity Required" & vbCrLf & "Price Of The Product is 250", "To Flower Cart", "Enter here")
        If (quantity = "Enter here" OrElse quantity = "") Then
            MessageBox.Show("Try Again!!")
        Else

            x = 250 * quantity
            con.Open()
            str = "insert into cart(quantity,product,amt,price) values('" & quantity & "','Ceramic Pots','" & x & "','250')"
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            MsgBox(quantity + " Items Added To Cart Successfully..")
            con.Close()
        End If
    End Sub
    Private Sub self_wattering_pots_Click(sender As Object, e As EventArgs) Handles self_wattering_pots.Click
        Dim quantity As String
        quantity = Microsoft.VisualBasic.InputBox("Enter The Quantity Required" & vbCrLf & "Price Of The Product is 500", "To Flower Cart", "Enter here")
        If (quantity = "Enter here" OrElse quantity = "") Then
            MessageBox.Show("Try Again!!")
        Else
            x = 500 * quantity
            con.Open()
            str = "insert into cart(quantity,product,amt,price) values('" & quantity & "','Self Watering Plants','" & x & "','500')"
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            MsgBox(quantity + " Items Added To Cart Successfully..")
            con.Close()
        End If
    End Sub
    Private Sub red_roses_Click(sender As Object, e As EventArgs) Handles red_roses.Click
        Dim quantity As String
        quantity = Microsoft.VisualBasic.InputBox("Enter The Quantity Required" & vbCrLf & "Price Of The Product is 80", "To Flower Cart", "Enter here")
        If (quantity = "Enter here" OrElse quantity = "") Then
            MessageBox.Show("Try Again!!")
        Else
            x = 80 * quantity
            con.Open()
            str = "insert into cart(quantity,product,amt,price) values('" & quantity & "','Red Roses','" & x & "','80')"
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            MsgBox(quantity + " Items Added To Cart Successfully..")
            con.Close()
        End If
    End Sub

    Private Sub tulips_Click(sender As Object, e As EventArgs) Handles tulips.Click
        Dim quantity As String
        quantity = Microsoft.VisualBasic.InputBox("Enter The Quantity Required" & vbCrLf & "Price Of The Product is 250", "To Flower Cart", "Enter here")
        If (quantity = "Enter here" OrElse quantity = "") Then
            MessageBox.Show("Try Again!!")
        Else
            x = 250 * quantity
            con.Open()
            str = "insert into cart(quantity,product,amt,price) values('" & quantity & "','Tulips','" & x & "','250')"
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            MsgBox(quantity + " Items Added To Cart Successfully..")
            con.Close()
        End If
    End Sub
    Private Sub Lilac_Click(sender As Object, e As EventArgs) Handles Lilac.Click
        Dim quantity As String
        quantity = Microsoft.VisualBasic.InputBox("Enter The Quantity Required" & vbCrLf & "Price Of The Product is 70", "To Flower Cart", "Enter here")
        If (quantity = "Enter here" OrElse quantity = "") Then
            MessageBox.Show("Try Again!!")
        Else
            x = 70 * quantity
            con.Open()
            str = "insert into cart(quantity,product,amt,price) values('" & quantity & "','Tulips','" & x & "','70')"
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            MsgBox(quantity + " Items Added To Cart Successfully..")
            con.Close()
        End If
    End Sub
    Private Sub Carnation_Click(sender As Object, e As EventArgs) Handles Carnation.Click
        Dim quantity As String
        quantity = Microsoft.VisualBasic.InputBox("Enter The Quantity Required" & vbCrLf & "Price Of The Product is 200", "To Flower Cart", "Enter here")
        If (quantity = "Enter here" OrElse quantity = "") Then
            MessageBox.Show("Try Again!!")
        Else
            x = 200 * quantity
            con.Open()
            str = "insert into cart(quantity,product,amt,price) values('" & quantity & "','Tulips','" & x & "','200')"
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            MsgBox(quantity + " Items Added To Cart Successfully..")
            con.Close()
        End If
    End Sub
    Private Sub cartt_Click(sender As Object, e As EventArgs) Handles cartt.Click
        Me.Hide()
        Flower_Cart.Show()

    End Sub

    Private Sub BunifuCustomLabel11_MouseEnter(sender As Object, e As EventArgs) Handles BunifuCustomLabel11.MouseEnter
        BunifuCustomLabel11.ForeColor = Color.White
    End Sub
    Private Sub BunifuCustomLabel11_MouseLeave(sender As Object, e As EventArgs) Handles BunifuCustomLabel11.MouseLeave
        BunifuCustomLabel11.ForeColor = Color.Crimson
    End Sub
    Private Sub BunifuCustomLabel11_MouseDoubleClick(sender As Object, e As EventArgs) Handles BunifuCustomLabel11.Click
        Application.Exit()
    End Sub

    Private Sub accessor_Paint(sender As Object, e As PaintEventArgs) Handles accessor.Paint

    End Sub

    Private Sub seedd_Paint(sender As Object, e As PaintEventArgs) Handles seedd.Paint

    End Sub
End Class