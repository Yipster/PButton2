   M S B A M L   `   `   `  ����F  BPeterButton, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:PeterButtonPeterButton  5   	       PeterButton.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:PeterButton     5   	   J FWpfAnimatedGif, Version=1.4.13.0, Culture=neutral, PublicKeyToken=null,gif"http://wpfanimatedgif.codeplex.com  5   	     � Title$  
MainWindow��5	   	   $��840px��6   $��1280px��6+    � WindowStyle$ SingleBorderWindow=�6:    � 
ResizeMode$ NoResize=�6\    � 	Resources 5
         MyButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType �� ImageSource	 �� Triggers
 P� Property P� Value  BGStyle ��Name  ClassroomStoryboard �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value��%�  &	        &	 �    &	 �    �� 5   
   " ��6&   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      � #��z��6   .+�5      �� $��Center=�6/   $��Center=�6L   5      5      5      �� 5       � �� 5      �� 5      $ Resources\poof.png��6!   5      	 5      P� 5      
 �@J�IsMouseOver . . �5      ��  � �� 5      �� 5      $  Resources\invertedpoof.png��6)   5       5!      5#      �� 5$   
   " ��6    .�5%      ��  � �� 5&      �� 5'      " ��6&   .R�5(      � #��z��6   .+�5)      �� $��Center=�6/   $��Center=�6L   5*      5+      5-      5.      �� 5/   
   $ ClassroomStoryboard��61   .��50      U� $ (UIElement.Opacity)�6,   $ ClassroomImg��6\   .\�51        $ 0:0:0.5��6'   $ 1Q�69     52      $ 0:0:6.5��6'   $	 0.1Q�69   53      54      55      .��56      �� -   5         ��Name$ 	Container��56      .+�58   
   �� "  WpfAnimatedGif.ImageBehavior   RepeatBehavior$ Forever��6      AnimatedSource$ Resources\Bird.gif��6;   $	��289��6r   $	��408��6    �� Left$	 862��6�   
 �� Top$	 163��6�   �� 59   
   -   5         ��Name$ ClassroomImg��59   F    K� ZIndex$ 1��6   #��[ 6$   $�� ��6\   $	��602��6g   $��1275.371��6t   
���   �
���   � J� RenderTransformOrigin$ 0.5,0.5&�6�   ��5:      �� 5;      $ empty classroom.jpg��6   6A   5=      �� 5?   
   -   5        $ ResetBtn��5?   L   $ 2��6   #��[  6$   $�� ��6^   $	��194��6i   $	��411��6v   
���   �
���   �$ 0.5,0.5&�6�   $	 602��6�   $	 430��6�   5@      �� 5A   
   -   5         ��Name$ underlay��5A      ���	#FFFFFEEC$	��210��67   
���   �$	 602��6S   $
��1280��6d   $ -3��6q   �� 5B   
   -   5         ��Name$ 	textBlock��5B      $��52��6'   $ 55��63   $
��Wrap=�6D   $��Good Clouds:��6X   $ 618.65��6l   $	��260��6�   $��40(�6�   $��Gautami)�6�   �� 5C   
   -   5        $ count��5C      $��58��6#   $ 55��6/   $
��Wrap=�6@   $ 675.65��6T   $	��208��6h   $��40(�6t   $��0��6�    �� TextAlignment$ Center=�6�   �� 5D   
   -   5        $ textBlock_Copy��5D      $��52��6,   $
 1009��68   $
��Wrap=�6K   $��High Score:��6_   $	 617��6r   $	��260��6�   $��40(�6�   $��Gautami)�6�   �� 5E   
   -   5        $ 	highscore��5E      $��58��6'   $
 1009��63   $
��Wrap=�6F   $	 674��6Z   $	��186��6k   $��40(�6w   $��0��6�   $ Center=�6�   5F      5G      