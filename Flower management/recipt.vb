Imports System.Data.SqlClient
Public Class recipt
    Dim con As New SqlConnection
    Dim da As New SqlDataAdapter
    Dim com As SqlCommand
    Dim cod As New SqlCommand
    Dim dr As SqlDataReader
    Dim dt As DataTable
    Dim dv As DataView
    Dim str As String
    Dim stu As String
    Public Sub New()
        InitializeComponent()
        BindGrid()
    End Sub
    Private Sub BindGrid()
        Dim constring As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Flower management\Flower management\flowers.mdf;Integrated Security=True"
        Using con As New SqlConnection(constring)
            Using cmd As New SqlCommand("SELECT * FROM cart", con)
                cmd.CommandType = CommandType.Text
                Using sda As New SqlDataAdapter(cmd)
                    Using dt As New DataTable()
                        sda.Fill(dt)
                        DataGridView1.DataSource = dt
                    End Using
                End Using
            End Using
        End Using
    End Sub
    Private Sub recipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FlowersDataSet8.cart' table. You can move, or remove it, as needed.
        Me.CartTableAdapter.Fill(Me.FlowersDataSet8.cart)

    End Sub

    Private Sub purchase_btn_Click(sender As Object, e As EventArgs) Handles purchase_btn.Click
        con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Flower management\Flower management\flowers.mdf;Integrated Security=True")
        con.Open()
        stu = "TRUNCATE TABLE cart"
        cod = New SqlCommand(stu, con)
        cod.ExecuteNonQuery()
        MsgBox("Thank You Please Fill the Feedback Form")
        con.Close()
        Me.Hide()
        feedback_form.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

End Class