Imports System.Windows
Imports System.Collections.ObjectModel

' ...
Namespace PieBindingToObservableCollection

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub
    End Class

    Public Class ViewModel

        Private _PointsCollection As ObservableCollection(Of System.Windows.Point)

        Public Property PointsCollection As ObservableCollection(Of Point)
            Get
                Return _PointsCollection
            End Get

            Private Set(ByVal value As ObservableCollection(Of Point))
                _PointsCollection = value
            End Set
        End Property

        Public Sub New()
            PointsCollection = New ObservableCollection(Of Point) From {New Point(1, 1), New Point(2, 2), New Point(3, 3)}
        End Sub

        Public Sub AddPoint()
            PointsCollection.Add(New Point(1, 1))
        End Sub
    End Class
End Namespace
