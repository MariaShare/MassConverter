<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Button2 = New Button()
        ComboBox1 = New ComboBox()
        TextBox1 = New TextBox()
        ComboBox2 = New ComboBox()
        Label1 = New Label()
        TextBox2 = New TextBox()
        CheckBox1 = New CheckBox()
        SuspendLayout()
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(143, 67)
        Button2.Name = "Button2"
        Button2.Size = New Size(154, 29)
        Button2.TabIndex = 1
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Килограмм", "Тонна", "Фунт", "Пуд", "Центнер"})
        ComboBox1.Location = New Point(12, 52)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(125, 28)
        ComboBox1.TabIndex = 2
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(12, 86)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 27)
        TextBox1.TabIndex = 3
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"Килограмм", "Тонна", "Фунт", "Пуд", "Центнер"})
        ComboBox2.Location = New Point(303, 52)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(125, 28)
        ComboBox2.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(16, 16)
        Label1.Name = "Label1"
        Label1.Size = New Size(53, 20)
        Label1.TabIndex = 5
        Label1.Text = "Label1"' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(303, 86)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(125, 27)
        TextBox2.TabIndex = 6
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(12, 119)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(103, 24)
        CheckBox1.TabIndex = 7
        CheckBox1.Text = "CheckBox1"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(442, 155)
        Controls.Add(CheckBox1)
        Controls.Add(TextBox2)
        Controls.Add(Label1)
        Controls.Add(ComboBox2)
        Controls.Add(TextBox1)
        Controls.Add(ComboBox1)
        Controls.Add(Button2)
        Name = "Form1"
        Text = "Конвертер массы"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents CheckBox1 As CheckBox
End Class
