   M S B A M L   `   `   `  ����B  >WpfApp3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp3WpfApp3  5   	       WpfApp3.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp3     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   
   $��678.423��5      $
��1024��6+     � WindowStartupLocation$  CenterScreen=�68    � 
ResizeMode$ NoResize=�6]    � WindowStyle$
 None=�6s   .��5
      � -   5        ���	#FFEEEEEE.+�5   
   �� $	��Top=�6   .+�5      � 
����  �$��10��6%   � 5      $��10q�6   .+�5      ��  �� Orientation$ 
Horizontal=�6   $��Right=�66   .+�5      �� $��30��6   $��30��6(   $��0q�6a   
�������$��0 0 10 0q�6   ��64   Z� ��6J   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Settings=�62   5      �� 5      -   5         ��Name$ ButtonFechar��5      $��30��63   $��30��6>   $��0q�6w   
���������6J   Z� ��6`   Z� .��5        $ Power=�62   5      5      5#      5'      � 5)   
   $��
250 55 0 0q�6   .+�5*      � -   5         �Name$ GridPrincipal��5*      $��Center=�6*   $��Center=�6G   � 5,      $��0��6   5;      � 5>   
   $	��250��6   
���   �$
��Left=�6.   .+�5@      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5          Name$ TrainsitionigContentSlide��5@   2   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6U   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromLeft+	   Duration$	 0:0:0.2X�.��5A      � -   5        $ 
GridCursor��5A      $��	0 100 0 0q�6+   ���	#FF0069C0$��10��6U   $
��Left=�6`   $��60��6{   $	��Top=�6�   5B      �� 5E      -   5        
 ��Name$
 ListViewMenu��5E      $��0 100q�6-   
�������$��Champagne & Limousines)�6S   $��18(�6{    �� SelectedIndex$ 0��6�   .@�5G      �� $��60��6   .��5H      �� $ 
Horizontal=�6!   .+�5I        $ 
Storefront=�62   $��30��6D   $��30��6O   $��Center=�6[   $��5q�6v   �� 5J      $
��Sell��6$   $��17(�60   $��Center=�6>   $
��20 0q�6Y   5K      5L      �� 5N      $��60��6   .��5O      �� $ 
Horizontal=�6!   .+�5P        $ Shopping=�62   $��30��6B   $��30��6M   $��Center=�6Y   $��5q�6t   �� 5Q      $	��Buy��6$   $��17(�6/   $��Center=�6=   $
��20 0q�6X   5R      5S      �� 5X      $��60��6   .��5Y      �� $ 
Horizontal=�6!   .+�5Z        $ CustomerService=�62   $��30��6I   $��30��6T   $��Center=�6`   $��5q�6{   �� 5[      $��	Customers��6$   $��17(�65   $��Center=�6C   $
��20 0q�6^   5\      5]      �� 5_      $��60��6   .��5`      �� $ 
Horizontal=�6!   .+�5a        $ RvTruck=�62   $��30��6A   $��30��6L   $��Center=�6X   $��5q�6s   �� 5b      $��	Suppliers��6$   $��17(�65   $��Center=�6C   $
��20 0q�6^   5c      5d      �� 5h      $��60��6   .��5i      �� $ 
Horizontal=�6!   .+�5j        $
 Book=�62   $��30��6>   $��30��6I   $��Center=�6U   $��5q�6p   �� 5k      $��CashBook��6$   $��17(�64   $��Center=�6B   $
��20 0q�6]   5l      5m      �� 5p      $��60��6   .��5q      �� $ 
Horizontal=�6!   .+�5r        $ LocalAtm=�62   $��30��6B   $��30��6M   $��Center=�6Y   $��5q�6t   �� 5s      $��Profit and Loss��6$   $��17(�6;   $��Center=�6I   $
��20 0q�6d   5t      5v      �� 5z      $��60��6   .��5{      �� $ 
Horizontal=�6!   .+�5|        $ Search=�62   $��30��6@   $��30��6K   $��Center=�6W   $��5q�6r   �� 5}      $��Search��6$   $��17(�62   $��Center=�6@   $
��20 0q�6[   5~      5      5�      5�      5�      5�      