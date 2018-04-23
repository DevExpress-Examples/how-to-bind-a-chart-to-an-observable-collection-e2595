Imports System.Windows
Imports System.Collections.ObjectModel
' ...

Namespace PieBindingToObservableCollection
    Partial Public Class MainWindow
        Inherits Window

        Public Shared ReadOnly PointsCollectionProperty As DependencyProperty = DependencyProperty.Register("PointsCollection", GetType(PointsCollection), GetType(MainWindow), New PropertyMetadata())

        Public Property PointsCollection() As PointsCollection
            Get
                Return DirectCast(GetValue(PointsCollectionProperty), PointsCollection)
            End Get
            Set(ByVal value As PointsCollection)
                SetValue(PointsCollectionProperty, value)
            End Set
        End Property

        Public Sub New()
            InitializeComponent()
            PointsCollection = New PointsCollection()
            PointsCollection.Add(New Point(1, 1))
            PointsCollection.Add(New Point(2, 2))
            PointsCollection.Add(New Point(3, 3))
        End Sub
        Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            PointsCollection.Add(New Point(1, 1))
        End Sub
    End Class

    Public Class PointsCollection
        Inherits ObservableCollection(Of Point)

    End Class
End Namespace
