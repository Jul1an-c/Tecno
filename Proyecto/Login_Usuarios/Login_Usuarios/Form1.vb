﻿Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Form1
    Dim con As New SqlConnection(My.Settings.Coneccion)
    Dim mensaje, sentencia As String

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

        Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub


    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub GunaGradient2Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub GunaTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub txt_Usuario_TextChanged(sender As Object, e As EventArgs) Handles txt_Usuario.TextChanged

    End Sub

    Private Sub txt_Contraseña_TextChanged(sender As Object, e As EventArgs) Handles txt_Contraseña.TextChanged
        txt_Contraseña.PasswordChar = "*"
    End Sub

    Private Sub oj_Mostrar_Click(sender As Object, e As EventArgs) Handles oj_Mostrar.Click
        oj_ocultar.BringToFront()
        txt_Contraseña.PasswordChar = ""

    End Sub

    Private Sub oj_ocultar_Click(sender As Object, e As EventArgs) Handles oj_ocultar.Click
        oj_Mostrar.BringToFront()
        txt_Contraseña.PasswordChar = "*"
    End Sub

    Private Sub btn_Ingresar_Click(sender As Object, e As EventArgs) Handles btn_Ingresar.Click
        Dim da As New SqlDataAdapter("select * from Usuarios_L Where Usuario='" & txt_Usuario.Text & "' And Contraseña='" & txt_Contraseña.Text & "'", con)
        Dim dt As New DataTable
        da.Fill(dt)
        'Validar'
        Dim validar As Integer = dt.Rows.Count
        'If'
        If validar > 0 Then
            Dim tipo As String = dt(0)("Id_Tipo")
            If tipo = 1 Then
                MsgBox("Bienvenido Usuario")
                frm_Usuario.Show()
                Me.Hide()
            Else
                If tipo = 2 Then
                    MsgBox("Bienvenido Administrador")
                    frm_Administrador.Show()
                    Me.Hide()
                ElseIf tipo = 3 Then
                    MsgBox("Bienvenido Secretaria")
                    frm_Usuario.Show()
                    Me.Hide()
                End If
            End If

        End If
        'Error textbox'
        If txt_Contraseña.Text = "" And txt_Usuario.Text = "" Then
            MsgBox("Ingrese Su USUARIO y CONTRASEÑA")
        Else
            If txt_Contraseña.Text = "" Then
                MsgBox("Ingrese su CONTRASEÑA")
            Else
                If txt_Usuario.Text = "" Then
                    MsgBox("Ingrese su USUARIO")
                End If
            End If
        End If
    End Sub

    Private Sub txt_Registrarse_Click(sender As Object, e As EventArgs) Handles txt_Registrarse.Click
        frm_Registros.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        frm_Usuario.Show()

    End Sub

End Class

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

public class Main {
    public static void main(String[] args) {
        String usuario = txt_Usuario.getText();
        String contraseña = txt_Contraseña.getText();
        
        try {
            Connection con = DriverManager.getConnection("jdbc:mysql://localhost:3306/tu_base_de_datos", "usuario", "contraseña");
            Statement stmt = con.createStatement();
            ResultSet rs = stmt.executeQuery("SELECT * FROM Usuarios_L WHERE Usuario='" + usuario + "' AND Contraseña='" + contraseña + "'");
            
            // Validar
            int validar = 0;
            if (rs.last()) {
                validar = rs.getRow();
                rs.beforeFirst();
            }
            
            // If
            if (validar > 0) {
                if (rs.next()) {
                    int tipo = rs.getInt("Id_Tipo");
                    if (tipo == 1) {
                        System.out.println("Bienvenido Usuario");
                        Frm_Usuario frmUsuario = new Frm_Usuario();
                        frmUsuario.setVisible(true);
                        // Cerrar la ventana actual
                    } else if (tipo == 2) {
                        System.out.println("Bienvenido Administrador");
                        Frm_Administrador frmAdministrador = new Frm_Administrador();
                        frmAdministrador.setVisible(true);
                        // Cerrar la ventana actual
                    } else if (tipo == 3) {
                        System.out.println("Bienvenido Secretaria");
                        Frm_Usuario frmUsuario = new Frm_Usuario();
                        frmUsuario.setVisible(true);
                        // Cerrar la ventana actual
                    }
                }
            }
            
            rs.close();
            stmt.close();
            con.close();
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }
}


