   M S B A M L   `   `   `  ����>  :UI2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:UI2.ViewUI2.View  5      -clr-namespace:UI2.ModelViewUI2.ModelView  5   	   clr-namespace:UI2UI2  5   	       UI2.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (viewsclr-namespace:UI2.View     5      1	viewModelclr-namespace:UI2.ModelView     5   	   $local1clr-namespace:UI2     5   	     � Title$  
MainWindow��5
   	   $	��350��6   $��571.5��6)   ��5      �� 5   
    �� ImageSource$ images\image3.jpg��6   67    � DataContext 5         UI2.MainWindowViewModel  5   
   .��5      � .+�5   
   �� $��294,10,212,257q�6   ��6)   �� *RadnikWindow+��5      �� 5       �� 
TargetType" ��6"   .R�5      � .+�5      A� 
�������6"   �� 5      $��images\people.png��6    �� 5       ��Name$ LabelSection��6!   $��0��5      $��0��5      $��46,14,-88,10q�5      
�������$��2q�5       �� CornerRadius$ 5��5      ._�5      �� $��Dodaj radnika��6$   
���   �$��-2,-4,0,-14q�5!      $	��Top=�5"      $��42��64   5#      5%      5&      5(      �� 5*   
   $��74,174,434,93q�6   ��6(   �� *AlatWindowCommand+��5+      �� 5,      " ��6"   .R�5-      � .+�5.      A� 
����ح�6"   �� 5/      $��images\alat2.png��6    $��5,4,6,0q�6:   �� 50      $ LabelSection��6!   $��0��51      $��0��52      $��46,14,-88,10q�53      
����ح�$��2q�55      $ 5��56      ._�57      �� $��
Dodaj alat��6$   
���   �$��-2,-4,0,-11q�59      $	��Top=�5:      $��39��64   5;      5=      5>      5@      �� 5A   
   $��336,67,170,205q�6   ��6)   �� *UslugaWindowCommand+��5B      �� 5C      " ��6"   .R�5D      � .+�5E      A� 
���iii�$��10,0,0,0q�61   �� 5F      $��images\usluga.png��6    $��10,0,6,0q�6;   �� 5G      $ LabelSection��6!   $��0��5H      $��0��5I      $��52,11,-88,10q�5J      
���iii�$��2q�5L      $ 5��5M      ._�5N      �� $��Dodaj uslugu��6$   
���   �$��-9,-4,0,-10q�5P      $	��Top=�5Q      $��36��64   5R      5T      5U      5W      �� 5X   
   $��500,255,10,10q�6   ��6(   �� *KvarWindowCommand+��5Y      �� 5Z      " ��6"   .R�5[      � .+�5\      A� 
�������6"   �� 5]      $��images\kvar.png��6    5`      5a      5c      5f      5g      