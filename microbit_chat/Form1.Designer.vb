<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.received_text = New System.Windows.Forms.TextBox()
        Me.str_out = New System.Windows.Forms.TextBox()
        Me.Send = New System.Windows.Forms.Button()
        Me.port_select = New System.Windows.Forms.ComboBox()
        Me.port = New System.Windows.Forms.Button()
        Me.serial = New System.IO.Ports.SerialPort(Me.components)
        Me.clrtxt = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'received_text
        '
        resources.ApplyResources(Me.received_text, "received_text")
        Me.received_text.Name = "received_text"
        Me.received_text.ReadOnly = True
        '
        'str_out
        '
        resources.ApplyResources(Me.str_out, "str_out")
        Me.str_out.Name = "str_out"
        '
        'Send
        '
        resources.ApplyResources(Me.Send, "Send")
        Me.Send.Name = "Send"
        Me.Send.UseVisualStyleBackColor = True
        '
        'port_select
        '
        Me.port_select.FormattingEnabled = True
        resources.ApplyResources(Me.port_select, "port_select")
        Me.port_select.Name = "port_select"
        '
        'port
        '
        resources.ApplyResources(Me.port, "port")
        Me.port.Name = "port"
        Me.port.UseVisualStyleBackColor = True
        '
        'serial
        '
        Me.serial.PortName = "portID"
        '
        'clrtxt
        '
        resources.ApplyResources(Me.clrtxt, "clrtxt")
        Me.clrtxt.Name = "clrtxt"
        Me.clrtxt.UseVisualStyleBackColor = True
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Form1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.clrtxt)
        Me.Controls.Add(Me.port)
        Me.Controls.Add(Me.port_select)
        Me.Controls.Add(Me.Send)
        Me.Controls.Add(Me.str_out)
        Me.Controls.Add(Me.received_text)
        Me.Name = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents str_out As TextBox
    Friend WithEvents Send As Button
    Friend WithEvents port_select As ComboBox
    Friend WithEvents port As Button
    Friend WithEvents serial As IO.Ports.SerialPort
    Friend WithEvents received_text As TextBox
    Friend WithEvents clrtxt As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
