   M S B A M L   `   `   `  ����>  :UI2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:UI2.ViewUI2.View  5   	   -clr-namespace:UI2.ModelViewUI2.ModelView  5   	       UI2.View.PopravljaView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:UI2.View     5   	   /local11clr-namespace:UI2.ModelView     5   	     � Title$  PopravljaView��5	   	   $	��300��6   $	��300��6,    � DataContext 5
      &    UI2.ModelView.PopravljaViewModel  5   
   .��5      � .+�5   
   �� $��Dodela popravki��6   $��Italic$�6*   $��15(�6=   $��73,5,67,233q�6K   �� 5   
   $��Izaberite majstora:��6   $��Italic$�6.   $��10,28,165,209q�6A   �� 5   
   $��Izaberite popravku:��6   $��Italic$�6.   $��157,29,0,209q�6A   �� 5   
   $��157,65,31,170q�6Z   ��6   �� *
KvarList+ �� SelectedItem 64   �� *SelectedKvar+6Z   �� 5   
   $��10,65,178,170q�6`   ��6   �� *MajstorList+ 67   �� *SelectedMajstor+6`   �� 5   
   $��0,0,687,376q�6   .+�5      �� 
�������$	��126��6|    �� Left$ 22��6�   
 �� Top$	 138��6�   $	��246��6�   ��6   �� *MajstorKvarList+ 6?   �� *SelectedItem+ �� View 5      �� 5      .P�5      �� $��
Tip  kvara��6)    �� DisplayMemberBinding 6=   �� *Value.Tip_kvara+�� 5      $��Prezime��6)    6:   �� *Key.Radnik.Prezime+�� 5      $	��Ime��6)    66   �� *Key.Radnik.Ime+5      5      5      �� 5    
   $��Dodaj��6   $��103,108,127,138q�6!   ��6:   �� *
AddCommand+�� 5!   
   $��Prikazi��6   $��199,108,31,138q�6#   ��6;   �� *ShowCommand+5#      5$      