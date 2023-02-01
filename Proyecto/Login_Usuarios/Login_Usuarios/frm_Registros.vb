Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Imports System.Data.OleDb
Imports System.Data.Sql

Public Class frm_Registros

    Dim con As New SqlConnection(My.Settings.Coneccion)
    Dim Sentencia, Mensaje As String

    Sub EjecutarSql(ByVal sql As String, ByVal msg As String)
        Try
            Dim cmd As New SqlCommand(sql, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox(msg)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_Nombre_MouseCaptureChanged(sender As Object, e As EventArgs) Handles txt_Nombre.MouseCaptureChanged
        txt_Nombre.Text = ("")
    End Sub

    Private Sub txt_Apellido_MouseCaptureChanged(sender As Object, e As EventArgs) Handles txt_Apellido.MouseCaptureChanged
        txt_Apellido.Text = ("")
    End Sub

    Private Sub txt_Usuario_MouseCaptureChanged(sender As Object, e As EventArgs) Handles txt_Usuario.MouseCaptureChanged
        txt_Usuario.Text = ("")
    End Sub

    Private Sub txt_Contraseña_MouseCaptureChanged(sender As Object, e As EventArgs) Handles txt_Contraseña.MouseCaptureChanged
        txt_Contraseña.Text = ("")
    End Sub

    Private Sub dtg_Registros_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub frm_Registros_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GunaLabel5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_Registrar_Click(sender As Object, e As EventArgs) Handles btn_Registrar.Click
        Sentencia = "Insert into Usuarios_L values('" + txt_Nombre.Text + "', '" + txt_Apellido.Text + "', '" + txt_Usuario.Text + "', '" + txt_Contraseña.Text + "', '" + txt_TipoUsu.Text + "')"
        Mensaje = "Datos Registrados Correctamente"
        Form1.Show()

        Try
            Dim da As New SqlDataAdapter("Select * from Usuarios_L", con)
            Dim ds As New DataSet
            da.Fill(ds)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.Hide()
        EjecutarSql(Sentencia, Mensaje)

    End Sub

End Class