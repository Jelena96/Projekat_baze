   M S B A M L   `   `   `  ����>  :UI2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:UI2.ViewUI2.View  5   	   -clr-namespace:UI2.ModelViewUI2.ModelView  5   	       UI2.View.KoristiView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:UI2.View     5   	   /local11clr-namespace:UI2.ModelView     5   	     � Title$  KoristiView��5	   	   $	��500��6   $	��500��6*    � DataContext 5
      $   UI2.ModelView.KoristiViewModel  5   
   .��5      � .+�5   
   �� $��Dodela alata��6   $��Italic$�6'   $��15(�6:   $��172,27,211,408q�6H   �� 5   
   $��Izaberite Kvar:��6   $��Italic$�6*   $��96,101,283,318q�6=   �� 5   
   $��Izaberite Alat:��6   $��Italic$�6*   $��244,101,114,326q�6=   �� 5   
   $��108,148,304,288q�6Z   ��6   �� *
KvarList+ �� SelectedItem 64   �� *SelectedKvar+6Z   �� 5   
   $��257,148,168,288q�6Z   ��6   �� *
AlatList+ 64   �� *SelectedAlat+6Z   �� 5   
   $��0,0,687,376q�6   .+�5      �� 
�������$	��145��6|    �� Left$ 62��6�   
 �� Top$	 239��6�   $	��326��6�   ��6   �� *MajstorKvarList+ 6?   �� *SelectedItem+ �� View 5      �� 5      .P�5      �� $��
Tip  kvara��6)    �� Width$ 80��6=    �� DisplayMemberBinding 6H   �� *Key.Kvar.Tip_kvara+�� 5      $��Prezime��6)   $ 80��6:    6F   �� *Key.Majstor.Radnik.Prezime+�� 5      $	��Ime��6)   $ 80��66    6B   �� *Key.Majstor.Radnik.Ime+�� 5      $
��Alat��6)   $ 80��67    6C   �� *Value.Naziv_alata+5      5      5       �� 5!   
   $��Dodaj��6   $��108,419,320,20q�6!   ��69   �� *
AddCommand+5"      5#      