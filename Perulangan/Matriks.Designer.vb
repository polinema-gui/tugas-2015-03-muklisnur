﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Matriks
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Lbl_matrik1 = New System.Windows.Forms.Label()
        Me.Lbl_operasi = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lbl_hasil = New System.Windows.Forms.Label()
        Me.Txb_matrik1 = New System.Windows.Forms.TextBox()
        Me.Cmb_operasi = New System.Windows.Forms.ComboBox()
        Me.Txb_matrik2 = New System.Windows.Forms.TextBox()
        Me.Txb_hasil = New System.Windows.Forms.TextBox()
        Me.btn_proses = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lbl_matrik1
        '
        Me.Lbl_matrik1.AutoSize = True
        Me.Lbl_matrik1.Location = New System.Drawing.Point(12, 27)
        Me.Lbl_matrik1.Name = "Lbl_matrik1"
        Me.Lbl_matrik1.Size = New System.Drawing.Size(42, 13)
        Me.Lbl_matrik1.TabIndex = 0
        Me.Lbl_matrik1.Text = "Matrik1"
        '
        'Lbl_operasi
        '
        Me.Lbl_operasi.AutoSize = True
        Me.Lbl_operasi.Location = New System.Drawing.Point(12, 115)
        Me.Lbl_operasi.Name = "Lbl_operasi"
        Me.Lbl_operasi.Size = New System.Drawing.Size(43, 13)
        Me.Lbl_operasi.TabIndex = 1
        Me.Lbl_operasi.Text = "Operasi"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 156)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Matrik 2"
        '
        'Lbl_hasil
        '
        Me.Lbl_hasil.AutoSize = True
        Me.Lbl_hasil.Location = New System.Drawing.Point(12, 252)
        Me.Lbl_hasil.Name = "Lbl_hasil"
        Me.Lbl_hasil.Size = New System.Drawing.Size(30, 13)
        Me.Lbl_hasil.TabIndex = 3
        Me.Lbl_hasil.Text = "Hasil"
        '
        'Txb_matrik1
        '
        Me.Txb_matrik1.Location = New System.Drawing.Point(57, 27)
        Me.Txb_matrik1.Multiline = True
        Me.Txb_matrik1.Name = "Txb_matrik1"
        Me.Txb_matrik1.Size = New System.Drawing.Size(362, 70)
        Me.Txb_matrik1.TabIndex = 4
        '
        'Cmb_operasi
        '
        Me.Cmb_operasi.FormattingEnabled = True
        Me.Cmb_operasi.Items.AddRange(New Object() {"Tambah", "Kurang"})
        Me.Cmb_operasi.Location = New System.Drawing.Point(57, 115)
        Me.Cmb_operasi.Name = "Cmb_operasi"
        Me.Cmb_operasi.Size = New System.Drawing.Size(362, 21)
        Me.Cmb_operasi.TabIndex = 5
        '
        'Txb_matrik2
        '
        Me.Txb_matrik2.Location = New System.Drawing.Point(57, 156)
        Me.Txb_matrik2.Multiline = True
        Me.Txb_matrik2.Name = "Txb_matrik2"
        Me.Txb_matrik2.Size = New System.Drawing.Size(362, 70)
        Me.Txb_matrik2.TabIndex = 6
        '
        'Txb_hasil
        '
        Me.Txb_hasil.Location = New System.Drawing.Point(57, 249)
        Me.Txb_hasil.Multiline = True
        Me.Txb_hasil.Name = "Txb_hasil"
        Me.Txb_hasil.Size = New System.Drawing.Size(362, 103)
        Me.Txb_hasil.TabIndex = 7
        '
        'btn_proses
        '
        Me.btn_proses.Location = New System.Drawing.Point(329, 367)
        Me.btn_proses.Name = "btn_proses"
        Me.btn_proses.Size = New System.Drawing.Size(90, 23)
        Me.btn_proses.TabIndex = 8
        Me.btn_proses.Text = "Proses"
        Me.btn_proses.UseVisualStyleBackColor = True
        '
        'Matriks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 402)
        Me.Controls.Add(Me.btn_proses)
        Me.Controls.Add(Me.Txb_hasil)
        Me.Controls.Add(Me.Txb_matrik2)
        Me.Controls.Add(Me.Cmb_operasi)
        Me.Controls.Add(Me.Txb_matrik1)
        Me.Controls.Add(Me.Lbl_hasil)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Lbl_operasi)
        Me.Controls.Add(Me.Lbl_matrik1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Matriks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Matriks Kalkulator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_matrik1 As System.Windows.Forms.Label
    Friend WithEvents Lbl_operasi As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Lbl_hasil As System.Windows.Forms.Label
    Friend WithEvents Txb_matrik1 As System.Windows.Forms.TextBox
    Friend WithEvents Cmb_operasi As System.Windows.Forms.ComboBox
    Friend WithEvents Txb_matrik2 As System.Windows.Forms.TextBox
    Friend WithEvents Txb_hasil As System.Windows.Forms.TextBox
    Friend WithEvents btn_proses As System.Windows.Forms.Button
End Class
