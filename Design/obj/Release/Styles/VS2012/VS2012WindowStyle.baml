   M S B A M L   `   `   `  ���� 
  Design0    *Whush.Demo.Styles.VS2012.VS2012WindowStyleR NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   TitleBarBackgroundBrush  �� Color  VS2012WindowBorderBrush # VS2012WindowBorderBrushInactive   VS2012WindowStatusForeground ( $VS2012WindowStatusForegroundInactive # VS2012WindowStyleTitleBarButton �� 
TargetType �� Property �� Value �� 
TargetType ��Name �� Triggers P� Property P� Value	 �� 
TargetName  VS2012WindowStyle'  !System.Windows.Shell.WindowChrome
   NonClientFrameEdges   GlassFrameThickness   ResizeBorderThickness   CaptionHeight&   System.Windows.Media.TextOptions   TextRenderingMode   TextFormattingMode �� Padding J� Opacity � ColumnDefinitions ��Name   IsHitTestVisibleInChrome �� Path �� Mode �� RelativeSource ��Name ��Name �� Stretch �� EdgeMode �� AncestorType F�Name3  -System.Windows.Media.Effects.DropShadowEffect   Color   Opacity    
BlurRadius!   ShadowDepth"   	Direction# �� 	Resources$ �� Triggers% �� Binding& �� Value   D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     %q  &	        &	      &	 &     &	 9     &	 L     &	 _     7  &	 �    7  7   7  7  7  7  7  7  7  7  �� $  #EFEFF2���� $  #EFEFF2���� $  #999999���� $  #FFFFFF���� $  #FFFFFF���� " ��.���  � |� .  ��  � �� �� " ��.R�� .+��� $ PART_border��
������ ��  P�  �@J�IsMouseOver . . ��� $	 PART_border�� � �� �#FFF�� $	 PART_border�� �@J�Opacity$	 0.7Q�P�  � �� . . ��� $	 PART_border��8    � ���� $	 PART_border�� �@J�Opacity$ 1Q���  � �� �#FFF�� " �.���  �@�WindowStyle$
 None=���  �@�AllowsTransparency . ��  � ��
 ���� ��  �@�
ResizeMode$ CanResizeWithGrip=���  �@ WindowChrome   $

 None=�$ 0q�$ 7q�$ 32Q�-   ��  � �� �� " �.R��� $ PART_Container��._�� $ 	ClearType=�$ Display=�.+��� $ PART_Border��$
��Auto��$
��Auto��#��z��8��  $��1q�$ 0q�._�]� $��Stretch=�
������ $��Stretch=�.+��� $ TitleBar��$	��Top=�$��0q�8�� $	 0.7Q�._�� $��32�� �� $��36 ��� �� $��34 ��� $��34 ��� $��34 �.+��� $
 Icon��-   $��0��$��Right=�$��4,-7,0,7q�$��32��$��32�� . ���� $
 Icon�$ OneWay=� �� *TemplatedParent+�� $ Caption��$��1��$
��Left=�$��Center=�$��4,0,0,0q�$��Segoe UI)�$��12(�$
 0.66Q����� $ Title�$ OneWay=� �� *TemplatedParent+�� $ 	MinButton��-   $��2��$	��Top=�$��34��$��26��8��  . .��� $��9��$��9��.+�F� $��1��$
 None=�$ Aliased=�=����     z � z  z �    ��j � z ��j �    ��[ � z ��[ 	����  �� $ ButtonL�$ 
Foreground��� $ 	MaxButton��-   $��3��$	��Top=�$��34��$��26��8��  . .��� $��9��$��9��.+�F� $ PART_MaxButton_Path��$��1��$
 None=�$ Aliased=�X����        � z     � z  z �     z �        �    @B � z @B �    �� � z �� 	����  �� $ ButtonL�$ 
Foreground��� $ CloseButton��-   $��4��$	��Top=�$��34��$��26��
���  ��8��  . .��� $��9��$��9��.+�F� $	��1.5��$
 None=�+����        � z  z �     z � z     	����  �� $ ButtonL�$ 
Foreground���  P�  �@�WindowState$ 	Maximized=�. ��� $	 PART_MaxButton_Path�� � ��| ��    ��- �@KL ��- �@KL  z �     z �    ��- �     	= �@KL  	= ���-     � z     � z @KL ���j @KL ���- @B � z @B 	P�  �@�WindowState$ Normal=�. ��� $	 PART_Border�� �@J�Effect   $ black��$	 0.5Q�$  7Q�$! 2Q�$	" 315Q�P�  �@�IsActive .  . ��� $	 PART_Border��8   � ��# ���� '��       " ��.���  � ��8  ��  � ��8  $ �� % �� *
IsActive+ �� $ WindowL�	& False.a���  � ��8  ��  � ��8 	 �� '��       " ��.���  �@ ResizeGripDirection$ BottomRight=�