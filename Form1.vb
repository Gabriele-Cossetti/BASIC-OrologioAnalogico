'Tratto da Manuale Farri-Piotti-Sbroggiò pag. 704 Esercizio 100

Imports System.Threading

Public Class Form1
    Dim ImmagineOrologio As Bitmap = My.Resources.Quadrante_orologio

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Width = 418
        Me.Height = 438
        Me.DoubleBuffered = True
        Timer1.Enabled = True
        Timer1.Interval = 1000
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Invalidate()
    End Sub

    Private Sub Form1_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        Dim PuntoCentrale As New Point(Me.ClientRectangle.Width / 2, Me.ClientRectangle.Height / 2)
        e.Graphics.DrawImage(ImmagineOrologio, PuntoCentrale.X - 200, PuntoCentrale.Y - 200)
        Me.Text = Format(Date.Today, "D")
        Dim Secondi As Integer = (Date.Now.Second * 6) + 270
        Dim Minuti As Integer = (Date.Now.Minute * 6) + 270
        Dim Ore As Integer = (Date.Now.Hour * 30) + 270
        Dim ColoreSfondo As Color = Color.White
        Dim PennaOre As New Pen(Color.Black, 8)
        e.Graphics.DrawPie(PennaOre, PuntoCentrale.X - 90, PuntoCentrale.Y - 90, 180, 180, Ore, 360)
        Dim CancellaOre As New Pen(ColoreSfondo, 10)
        e.Graphics.DrawEllipse(CancellaOre, PuntoCentrale.X - 90, PuntoCentrale.Y - 90, 180, 180)
        Dim PennaMinuti As New Pen(Color.Black, 4)
        e.Graphics.DrawPie(PennaMinuti, PuntoCentrale.X - 110, PuntoCentrale.Y - 110, 220, 220, Minuti, 360)
        Dim CancellaMinuti As New Pen(ColoreSfondo, 8)
        e.Graphics.DrawEllipse(CancellaMinuti, PuntoCentrale.X - 110, PuntoCentrale.Y - 110, 220, 220)
        Dim PennaSecondi As New Pen(Color.Red, 1)
        e.Graphics.DrawPie(PennaSecondi, PuntoCentrale.X - 130, PuntoCentrale.Y - 130, 260, 260, Secondi, 360)
        Dim CancellaSecondi As New Pen(ColoreSfondo, 3)
        e.Graphics.DrawEllipse(CancellaSecondi, PuntoCentrale.X - 130, PuntoCentrale.Y - 130, 260, 260)
        e.Graphics.FillEllipse(Brushes.Black, PuntoCentrale.X - 10, PuntoCentrale.Y - 10, 20, 20)
        e.Graphics.FillEllipse(Brushes.Red, PuntoCentrale.X - 4, PuntoCentrale.Y - 4, 8, 8)
    End Sub
End Class


