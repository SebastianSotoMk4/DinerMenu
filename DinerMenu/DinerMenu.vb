'Sebastian Soto
'RCET0265
'Fall 2021
'Diner Menu
'https://github.com/SebastianSotoMk4/DinerMenu.git
Option Strict On
Option Explicit On
Public Class DinerMenu
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub LateNightButton_Click(sender As Object, e As EventArgs) Handles LateNightButton.Click
        MsgBox("Salami, Capicola, ham, cheese, onion, oil & vinegar and oregano-basil")
    End Sub

    Private Sub TheVisualBasicButton_Click(sender As Object, e As EventArgs) Handles TheVisualBasicButton.Click
        MsgBox("ham & cheese")
    End Sub

    Private Sub CompileTunaButton_Click(sender As Object, e As EventArgs) Handles CompileTunaButton.Click
        MsgBox("Tuna salad, double cheese & cucumber (no mayo*)")
    End Sub

    Private Sub VBLTButton_Click(sender As Object, e As EventArgs) Handles VBLTButton.Click
        MsgBox("Vienna sausages with Bacon Lettuce and tomato")
    End Sub
End Class
