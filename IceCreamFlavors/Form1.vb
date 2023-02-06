Option Explicit On
Option Strict On
Option Infer Off

Public Class Form1
    Private Sub lstFlavor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstFlavor.SelectedIndexChanged
        If lstFlavor.SelectedIndex = 0 Then
            picIceCream.Image = My.Resources.Vanilla_icecream
        ElseIf lstFlavor.SelectedIndex = 1 Then
            picIceCream.Image = My.Resources.Chocolate_icecream
        ElseIf lstFlavor.SelectedIndex = 2 Then
            picIceCream.Image = My.Resources.Strawberry_icecream
        ElseIf lstFlavor.SelectedIndex = 3 Then
            picIceCream.Image = My.Resources.Blueberry_icecream
        ElseIf lstFlavor.SelectedIndex = 4 Then
            picIceCream.Image = My.Resources.Mint_icecream
        End If
    End Sub
End Class
