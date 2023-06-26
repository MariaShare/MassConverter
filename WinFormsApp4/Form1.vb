Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Введите значение и выберите единицы измерения"
        CheckBox1.Text = "Очистить"
        Button2.Text = "Конвертировать"
    End Sub
    Private Sub Convert(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then
            MsgBox("Введите значение!")
        Else
            Dim mass1 = CDbl(TextBox1.Text)
            Dim F1 = ComboBox1.SelectedIndex
            Dim F2 = ComboBox2.SelectedIndex
            Select Case F1
                Case 0
                    Case2(mass1)
                Case 1
                    Case2(t_kg(mass1))
                Case 2
                    Case2(f_kg(mass1))
                Case 3
                    Case2(p_kg(mass1))
                Case 4
                    Case2(c_kg(mass1))
                Case Else
                    MsgBox("Выберите единицу измерения!")
            End Select
        End If
    End Sub
    Private Sub Case2(mass1 As Double)
        Dim F2 = ComboBox2.SelectedIndex
        Select Case F2
            Case 0
                Out_TextBoxl(Str(mass1))
            Case 1
                Out_TextBoxl(Str(kg_t(mass1)))
            Case 2
                Out_TextBoxl(Str(kg_f(mass1)))
            Case 3
                Out_TextBoxl(Str(kg_p(mass1)))
            Case 4
                Out_TextBoxl(Str(kg_c(mass1)))
            Case Else
                MsgBox("Выберите единицу измерения!")
        End Select
    End Sub
    Private Sub Clear(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        TextBox1.Text = ""
        TextBox2.Text = ""
        CheckBox1.Checked = False
    End Sub
    Private Function t_kg(mass As Double) As Double
        Return mass * 1000
    End Function
    Private Function f_kg(mass As Double) As Double
        Return mass * 0.409
    End Function
    Private Function p_kg(mass As Double) As Double
        Return mass * 16.38
    End Function
    Private Function c_kg(mass As Double) As Double
        Return mass * 100
    End Function
    Private Function kg_t(mass As Double) As Double
        Return mass / 1000
    End Function
    Private Function kg_f(mass As Double) As Double
        Return mass / 0.409
    End Function
    Private Function kg_p(mass As Double) As Double
        Return mass / 16.38
    End Function
    Private Function kg_c(mass As Double) As Double
        Return mass / 100
    End Function
    Private Sub Out_TextBoxl(strin As String)
        TextBox2.Text = Str(Val(strin))
    End Sub
End Class
