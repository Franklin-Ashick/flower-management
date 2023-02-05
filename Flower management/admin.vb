Imports System.Data.SqlClient
Imports System.Data
Public Class admin
    Dim con As New SqlConnection
    Dim da As New SqlDataAdapter
    Dim com As SqlCommand
    Dim ds As New DataSet
    Dim dr As SqlDataReader
    Dim dt As DataTable
    Dim dv As DataView
    Dim str As String
    Dim stu As Object
    Private Sub admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FlowersDataSet6.sales' table. You can move, or remove it, as needed.
        Me.SalesTableAdapter2.Fill(Me.FlowersDataSet6.sales)
        'TODO: This line of code loads data into the 'FlowersDataSet5.sales' table. You can move, or remove it, as needed.
        Me.SalesTableAdapter1.Fill(Me.FlowersDataSet5.sales)
        'TODO: This line of code loads data into the 'FlowersDataSet4.item' table. You can move, or remove it, as needed.
        Me.ItemTableAdapter.Fill(Me.FlowersDataSet4.item)
        'TODO: This line of code loads data into the 'FlowersDataSet3.stock' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.FlowersDataSet2.customer)

    End Sub
    'pannels
    Private Sub Sales_report_Click(sender As Object, e As EventArgs) Handles Sales_report.Click
        salesreport.Visible = True
        customers.Visible = False
        inventoryy.Visible = False

    End Sub
    Private Sub coustmers_Click(sender As Object, e As EventArgs) Handles coustmers.Click
        salesreport.Visible = False
        customers.Visible = True
        inventoryy.Visible = False

    End Sub
    Private Sub inventory_Click(sender As Object, e As EventArgs) Handles inventory.Click
        salesreport.Visible = False
        customers.Visible = False
        inventoryy.Visible = True

    End Sub
    'customer details
    'add
    Private Sub add_btt_Click(sender As Object, e As EventArgs) Handles add_btt.Click
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Flower management\Flower management\flowers.mdf;Integrated Security=True")
        con.Open()
        str = "insert into customer(c_name,c_mail,address,c_phno) values('" + fname.Text + "','" + email.Text + "','" + address.Text + "','" + PhNumber.Text + "')"
        com = New SqlCommand(str, con)
        com.ExecuteNonQuery()
        MsgBox("Customer Details Inserted Successfully..")
        Using con
            str = "select * from customer"
            com = New SqlCommand(str, con)
            da = New SqlDataAdapter(com)
            dt = New DataTable()
            dv = New DataView()
            da.Fill(dt)
            DataGridView1.DataSource = New BindingSource(dt, stu)
        End Using
        con.Close()
    End Sub
    'update
    Private Sub update_btn_Click(sender As Object, e As EventArgs) Handles update_btn.Click
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Flower management\Flower management\flowers.mdf;Integrated Security=True")
        con.Open()
        str = "update customer set c_name='" + fname.Text + "',c_mail='" + email.Text + "',address='" + address.Text + "',c_phno='" + PhNumber.Text + "'"
        com = New SqlCommand(str, con)
        com.ExecuteNonQuery()
        MsgBox("Deatails Updated Successfully..")
        Using con
            str = "select * from customer"
            com = New SqlCommand(str, con)
            da = New SqlDataAdapter(com)
            dt = New DataTable()
            dv = New DataView()
            da.Fill(dt)
            DataGridView1.DataSource = New BindingSource(dt, stu)
        End Using
        con.Close()
    End Sub
    'delete
    Private Sub delete_btn_Click(sender As Object, e As EventArgs) Handles delete_btn.Click
        Try
            If (MsgBox(“Are you sure you want to delete the Details?”, MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Flower management\Flower management\flowers.mdf;Integrated Security=True")
                con.Open()
                str = "DELETE FROM customer WHERE c_name='" + fname.Text + "'"
                com = New SqlCommand(str, con)
                com.ExecuteNonQuery()
                MsgBox("Deleted Successfully..")
                Using con
                    str = "select * from customer"
                    com = New SqlCommand(str, con)
                    da = New SqlDataAdapter(com)
                    dt = New DataTable()
                    dv = New DataView()
                    da.Fill(dt)
                    DataGridView1.DataSource = New BindingSource(dt, stu)
                End Using
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub
    'inventories
    'add
    Private Sub BunifuThinButton24_Click(sender As Object, e As EventArgs) Handles BunifuThinButton24.Click
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Flower management\Flower management\flowers.mdf;Integrated Security=True")
        con.Open()
        str = "insert into item(I_name,quantity,i_type,price) values('" + iname.Text + "','" + quantityy.Text + "','" + type.Text + "','" + price.Text + "')"
        com = New SqlCommand(str, con)
        com.ExecuteNonQuery()
        MsgBox("Stock Details Inserted Successfully..")
        Using con
            str = "select * from item"
            com = New SqlCommand(str, con)
            da = New SqlDataAdapter(com)
            dt = New DataTable()
            dv = New DataView()
            da.Fill(dt)
            DataGridView2.DataSource = New BindingSource(dt, stu)
        End Using
        con.Close()
    End Sub
    'update
    Private Sub BunifuThinButton22_Click(sender As Object, e As EventArgs) Handles BunifuThinButton22.Click
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Flower management\Flower management\flowers.mdf;Integrated Security=True")
        con.Open()
        str = "update item set I_name='" + iname.Text + "',quantity='" + quantityy.Text + "',i_type='" + type.Text + "',price='" + price.Text + "'"
        com = New SqlCommand(str, con)
        com.ExecuteNonQuery()
        MsgBox("Stock Updated Successfully..")
        Using con
            str = "select * from item"
            com = New SqlCommand(str, con)
            da = New SqlDataAdapter(com)
            dt = New DataTable()
            dv = New DataView()
            da.Fill(dt)
            DataGridView2.DataSource = New BindingSource(dt, stu)
        End Using
        con.Close()
    End Sub
    'delete
    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        Try
            If (MsgBox(“Are you sure you want to delete the Details?”, MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Flower management\Flower management\flowers.mdf;Integrated Security=True")
                con.Open()
                str = "DELETE FROM item WHERE I_name='" + iname.Text + "'"
                com = New SqlCommand(str, con)
                com.ExecuteNonQuery()
                MsgBox("Deleted Successfully..")
                Using con
                    str = "select * from item"
                    com = New SqlCommand(str, con)
                    da = New SqlDataAdapter(com)
                    dt = New DataTable()
                    dv = New DataView()
                    da.Fill(dt)
                    DataGridView2.DataSource = New BindingSource(dt, stu)
                End Using
                con.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub
    'close
    Private Sub BunifuCustomLabel11_MouseEnter(sender As Object, e As EventArgs) Handles BunifuCustomLabel11.MouseEnter
        BunifuCustomLabel11.ForeColor = Color.White
    End Sub
    Private Sub BunifuCustomLabel11_MouseLeave(sender As Object, e As EventArgs) Handles BunifuCustomLabel11.MouseLeave
        BunifuCustomLabel11.ForeColor = Color.Crimson
    End Sub
    Private Sub BunifuCustomLabel11_MouseDoubleClick(sender As Object, e As EventArgs) Handles BunifuCustomLabel11.Click
        Me.Hide()
        Login.Show()

    End Sub

    Private Sub BunifuShadowPanel1_ControlAdded(sender As Object, e As ControlEventArgs) Handles BunifuShadowPanel1.ControlAdded

    End Sub

    Private Sub salesreport_Paint(sender As Object, e As PaintEventArgs) Handles salesreport.Paint

    End Sub
End Class
