﻿Namespace Grid_IconRangeCondition
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.dashboardViewer1 = New DevExpress.DashboardWin.DashboardViewer(Me.components)
            Me.button1 = New System.Windows.Forms.Button()
            DirectCast(Me.dashboardViewer1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' dashboardViewer1
            ' 
            Me.dashboardViewer1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dashboardViewer1.Location = New System.Drawing.Point(0, 0)
            Me.dashboardViewer1.Name = "dashboardViewer1"
            Me.dashboardViewer1.PrintingOptions.FontInfo.GdiCharSet = (CByte(0))
            Me.dashboardViewer1.PrintingOptions.FontInfo.Name = Nothing
            Me.dashboardViewer1.Size = New System.Drawing.Size(642, 328)
            Me.dashboardViewer1.TabIndex = 0
            ' 
            ' button1
            ' 
            Me.button1.Location = New System.Drawing.Point(57, 12)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(113, 23)
            Me.button1.TabIndex = 1
            Me.button1.Text = "Update Formatting"
            Me.button1.UseVisualStyleBackColor = True
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(642, 328)
            Me.Controls.Add(Me.button1)
            Me.Controls.Add(Me.dashboardViewer1)
            Me.Name = "Form1"
            Me.Text = "Dashboard Viewer"
            DirectCast(Me.dashboardViewer1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private dashboardViewer1 As DevExpress.DashboardWin.DashboardViewer
        Private WithEvents button1 As System.Windows.Forms.Button

    End Class
End Namespace
