   M S B A M L   `   `   `  ����A  =Design, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:DesignDesign  5          
Design.App   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      &localclr-namespace:Design     5        �� 	Resources  5       �� MergedDictionaries �� Source   placeHolder �� 
TargetType �� BasedOn �� Property  TitleBarBackgroundBrush �� Value �� 
TargetType �� Triggers	 :� RoutedEvent
 �� TargetProperty g� Duration W� From	 W� To ��Name K� ZIndex �� Path �� RelativeSource �� Mode �� UpdateSourceTrigger
 � Tag �� Binding �� Source%  System.Windows.Markup.Reference �� Value�� 5   
    5      �� 5	      $* $Styles/VS2012/VS2012WindowStyle.xaml?�6%   %�  &	        7��7  �� 5      " ��6(   8   .�5      ��  � ��8  6/   �� 5       � �� 5      �� 5      " ��6*   .R�5      � #��z��6#   ��5   "   �� 5   &   " �6,    5   *   :� 5   .   $	 Loaded��6;   .[�5   2   �� .��5   6   �� .��5   :   W� $
 Opacity�6J   $ 0:0:1D�6n   $	 0.5X�6   $ 1X�6�   5   7   5   3   5   /   5   '   .+�5   "   �� $ 
textSource��5#   "   
������ $ 2��5%   "   #��z��5&   "   ��5   *   �� $
 Text� �� *TemplatedParent+$ TwoWay=�$ PropertyChanged=�.��5'   #   5(   #   �� 5)   "   #��z 6*   #��z��6G   
������ $ 1��6�   .��6�   ��5*   &   �� 5+   *   " ��60   .�5,   .   ��  � ��
 ���� 6K    5-   .   �� 5.   2    6>   �� $
 Text�   *
textSource+  6}   .a�5/   6   ��  � ��
 �iii�6S   50   3   52   +   .��53   5   54   #   55      56      58      59      5:      5<      