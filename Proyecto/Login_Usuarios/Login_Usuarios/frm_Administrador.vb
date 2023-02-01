Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Imports System.Data.OleDb
Imports System.Data.Sql
Public Class frm_Administrador

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
    Private Sub GunaTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Sentencia = "update Usuarios_L set Id_usuarios= '" + TextBox1.Text + "',Nombre='" + TextBox2.Text + "',Apellido='" + TextBox3.Text + "',Usuario='" + TextBox5.Text + "',Contraseña='" + TextBox6.Text + "', Id_Tipo='" + TextBox6.Text + "'"
        Mensaje = "Datos actualizado correctamente"
        EjecutarSql(Sentencia, Mensaje)
        Try
            Dim da As New SqlDataAdapter("Select * from Usuarios_L", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Sentencia = "Delete Usuarios_L where Id_usuarios = '" + TextBox1.Text + "'"
        Mensaje = "Datos Eliminados Correctamente"
        EjecutarSql(Sentencia, Mensaje)
        Try
            Dim da As New SqlDataAdapter("select * from Usuarios_L", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Dim da As New SqlDataAdapter("Select * from Usuarios_L where Id_usuarios = '" + TextBox1.Text + "'", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim da As New SqlDataAdapter("Select * from Usuarios_L", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class