   M S B A M L   `   `   `  ����N  JCadastroPessoas.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:CadastroPessoas.WPFCadastroPessoas.WPF  5   	   $    CadastroPessoas.WPF.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:CadastroPessoas.WPF     5   	   -   5          �Name$  
WindowMain��5   	    � Title$ Cadastro de Pessoas��5   	   $��377.184��6%   $��872.816��66    � WindowStartupLocation$ CenterScreen=�6F    � 
ResizeMode$ NoResize=�6k   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 
dgrPessoas��5
      $
��Left=�6'   $	��298��6B   $��	10,10,0,0q�6O   $	��Top=�6b   $	��834��6z      
IsReadOnly .    SelectionMode$ Single=�6�   $ �� IsSynchronizedWithCurrentItem$ FalseY�6�      AutoGenerateColumns .  	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Id��6_      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6k   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *id+   ClipboardContentBinding 6<   Z� 6k     5      $

 Nome��6a   $ * 6o    6%   �� *nome+ 6>   Z� 6o     5      $
 Idade��6b   $ * 6q    6%   �� *idade+ 6?   Z� 6q     5      $
 	Endereço��6e   $ * 6w    6%   �� *
endereco+ 6B   Z� 6w   5      �� 5   
   -   5         ��Name$ btnAdicionar��5      $��	Adicionar��6'   $
��Left=�6;   $��744,313,0,0q�6V   $	��Top=�6k   $	��100��6�   6�   5      5      