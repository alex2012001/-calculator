   M S B A M L   `   `   `  ����E  Acalculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:calculator
calculator  5   	       calculator.if4   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:calculator     5   	     � Title$	  if4��5   	   $	��500��6   $	��720��6"   .��5	      � .+�5
   
   �� $
��Left=�6   $��5,10,0,0q�6/   $
��Wrap=�6A   $��Player1��6U   $	��Top=�6d   $��48(�6|   $��Times New Roman)�6�   �� 5   
   $
��Left=�6   $��
187,10,0,0q�6/   $
��Wrap=�6C   $��Player2��6W   $	��Top=�6f   $��48(�6~   $��Times New Roman)�6�   �� 5   
   $
��Left=�6   $��
368,10,0,0q�6/   $
��Wrap=�6C   $��Player3��6W   $	��Top=�6f   $��48(�6~   $��Times New Roman)�6�   �� 5   
   $
��Left=�6   $��
550,10,0,0q�6/   $
��Wrap=�6C   $��Player4��6W   $	��Top=�6f   $��48(�6~   $��Times New Roman)�6�   �� 5   
   $
��Left=�6   $��	28,84,0,0q�6/   $
��Wrap=�6B   $��
Атака��6V   $	��Top=�6c   $��36(�6{   $��Times New Roman)�6�   �� 5   
   -   5        $	��P1A��5      $
��Left=�6   $��23��68   $��
16,130,0,0q�6D    �� TextWrapping$
 Wrap=�6X   $��0��6l   $	��Top=�6u   $	��114��6�   $��16(�6�   $��Times New Roman)�6�   �� 5   
   $
��Left=�6   $��
17,197,0,0q�6/   $
��Wrap=�6C   $��Защита��6W   $	��Top=�6e   $��36(�6}   $��Times New Roman)�6�   �� 5   
   $
��Left=�6   $��
17,312,0,0q�6/   $
��Wrap=�6C   $��Здоровье��6W   $	��Top=�6g   $��36(�6   $��Times New Roman)�6�   �� 5   
   $
��Left=�6   $��
212,84,0,0q�6/   $
��Wrap=�6C   $��
Атака��6W   $	��Top=�6d   $��36(�6|   $��Times New Roman)�6�   �� 5   
   $
��Left=�6   $��201,197,0,0q�6/   $
��Wrap=�6D   $��Защита��6X   $	��Top=�6f   $��36(�6~   $��Times New Roman)�6�   �� 5   
   $
��Left=�6   $��201,312,0,0q�6/   $
��Wrap=�6D   $��Здоровье��6X   $	��Top=�6h   $��36(�6�   $��Times New Roman)�6�   �� 5   
   -   5        $	��P2A��5      $
��Left=�6   $��23��68   $��201,130,0,0q�6D   $
 Wrap=�6Y   $��0��6m   $	��Top=�6v   $	��114��6�   $��16(�6�   $��Times New Roman)�6�   �� 5   
   -   5        $	��P1P��5      $
��Left=�6   $��23��68   $��
16,243,0,0q�6D   $
 Wrap=�6X   $��0��6l   $	��Top=�6u   $	��114��6�   $��16(�6�   $��Times New Roman)�6�   �� 5   
   -   5        $	��P2P��5      $
��Left=�6   $��23��68   $��200,243,0,0q�6D   $
 Wrap=�6Y   $��0��6m   $	��Top=�6v   $	��114��6�   $��16(�6�   $��Times New Roman)�6�   �� 5   
   -   5        $	��P1H��5      $
��Left=�6   $��23��68   $��
28,358,0,0q�6D   $
 Wrap=�6X   $��0��6l   $	��Top=�6u   $	��114��6�   $��16(�6�   $��Times New Roman)�6�   �� 5   
   -   5        $	��P2H��5      $
��Left=�6   $��23��68   $��201,358,0,0q�6D   $
 Wrap=�6Y   $��0��6m   $	��Top=�6v   $	��114��6�   $��16(�6�   $��Times New Roman)�6�   �� 5   
   $
��Left=�6   $��
396,84,0,0q�6/   $
��Wrap=�6C   $��
Атака��6W   $	��Top=�6d   $��36(�6|   $��Times New Roman)�6�   �� 5   
   $
��Left=�6   $��385,197,0,0q�6/   $
��Wrap=�6D   $��Защита��6X   $	��Top=�6f   $��36(�6~   $��Times New Roman)�6�   �� 5   
   $
��Left=�6   $��385,312,0,0q�6/   $
��Wrap=�6D   $��Здоровье��6X   $	��Top=�6h   $��36(�6�   $��Times New Roman)�6�   �� 5   
   -   5        $	��P3A��5      $
��Left=�6   $��23��68   $��385,130,0,0q�6D   $
 Wrap=�6Y   $��0��6m   $	��Top=�6v   $	��114��6�   $��16(�6�   $��Times New Roman)�6�   �� 5    
   -   5        $	��P3P��5       $
��Left=�6   $��23��68   $��384,243,0,0q�6D   $
 Wrap=�6Y   $��0��6m   $	��Top=�6v   $	��114��6�   $��16(�6�   $��Times New Roman)�6�   �� 5!   
   -	   5        $	��P3H��5!      $
��Left=�6   $��23��68   $��385,358,0,0q�6D   $
 Wrap=�6Y   $��0��6m   $	��Top=�6v   $	��114��6�   $��16(�6�   $��Times New Roman)�6�   �� 5#   
   $
��Left=�6   $��
575,84,0,0q�6/   $
��Wrap=�6C   $��
Атака��6W   $	��Top=�6d   $��36(�6|   $��Times New Roman)�6�   �� 5$   
   $
��Left=�6   $��564,197,0,0q�6/   $
��Wrap=�6D   $��Защита��6X   $	��Top=�6f   $��36(�6~   $��Times New Roman)�6�   �� 5%   
   $
��Left=�6   $��564,312,0,0q�6/   $
��Wrap=�6D   $��Здоровье��6X   $	��Top=�6h   $��36(�6�   $��Times New Roman)�6�   �� 5&   
   -
   5        $	��P4A��5&      $
��Left=�6   $��23��68   $��564,130,0,0q�6D   $
 Wrap=�6Y   $��0��6m   $	��Top=�6v   $	��114��6�   $��16(�6�   $��Times New Roman)�6�   �� 5'   
   -   5        $	��P4P��5'      $
��Left=�6   $��23��68   $��563,243,0,0q�6D   $
 Wrap=�6Y   $��0��6m   $	��Top=�6v   $	��114��6�   $��16(�6�   $��Times New Roman)�6�   �� 5(   
   -   5        $	��P4H��5(      $
��Left=�6   $��23��68   $��564,358,0,0q�6D   $
 Wrap=�6Y   $��0��6m   $	��Top=�6v   $	��114��6�   $��16(�6�   $��Times New Roman)�6�   �� 5*   
   -   5        $��
Старт��5*      $
��Left=�6!   $��568,399,0,0q�6<   $	��Top=�6Q   $	��134��6i   $��48(�6u   $��60��6�   $��Times New Roman)�6�   6�   �� 5+   
   -   5        $	��Way��5+      $
��Left=�6   $��28��68   $��
28,431,0,0q�6D   $
 Wrap=�6X   $/��)C:\Users\Пользователь\Desktop��6l   $	��Top=�6�   $	��471��6�   �� 5,   
   $
��Left=�6   $��
28,410,0,0q�6/   $
��Wrap=�6C   $F��@Введите путь для сохранения файлов��6W   $	��Top=�6�   5.      5/      