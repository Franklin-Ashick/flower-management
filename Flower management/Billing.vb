Imports System.Data.SqlClient
Public Class Billing
    Dim con As New SqlConnection
    Dim da As New SqlDataAdapter
    Dim com As SqlCommand
    Dim cod As New SqlCommand
    Dim dr As SqlDataReader
    Dim dt As DataTable
    Dim dv As DataView
    Dim str As String
    Dim stu As String

    Dim f1 As Flower_Cart
    Public Sub New(ByVal frm1 As Flower_Cart)
        InitializeComponent()
        f1 = frm1
    End Sub
    Private Sub Billing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        quality.Text = f1.quality.Text
        amount.Text = f1.amount.Text
        upii.Visible = False
        card.Visible = False
        Cash.Visible = False
        card.BackColor = Color.FromArgb(25, Color.Black)
        upii.BackColor = Color.FromArgb(25, Color.Black)
        Cash.BackColor = Color.FromArgb(25, Color.Black)
    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        upii.Visible = False
        card.Visible = True
        Cash.Visible = False
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        upii.Visible = False
        card.Visible = False
        Cash.Visible = True
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        upii.Visible = True
        card.Visible = False
        Cash.Visible = False
    End Sub

    Private Sub purchase_btn_Click(sender As Object, e As EventArgs) Handles purchase_btn.Click
        If (name.Text = "" And phnumber.Text = "") Then
            MsgBox("Fill The details")
        Else
            con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Flower management\Flower management\flowers.mdf;Integrated Security=True")
            con.Open()
            str = "insert into sales(Name,PhNumber,Quantity,Total_Price) values('" + Name.Text + "','" + phnumber.Text + "','" + quality.Text + "','" + amount.Text + "')"
            com = New SqlCommand(str, con)
            com.ExecuteNonQuery()
            MsgBox("Purchased Successfully..")
            con.Close()

            recipt.Show()

        End If

    End Sub

    Private Sub BunifuCustomLabel11_MouseDoubleClick(sender As Object, e As EventArgs) Handles BunifuCustomLabel11.Click
        Me.Hide()
        Flower_Cart.Show()
    End Sub

    Private Sub Name_OnValueChanged(sender As Object, e As EventArgs) Handles Name.OnValueChanged

    End Sub

    Private Sub PAYMENT_Click(sender As Object, e As EventArgs) Handles PAYMENT.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class