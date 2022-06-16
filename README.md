# TreeView


Projekt który pozwala wyświetlić elementy w postaci drzewa.  
Główne okno pokazuje drzewo z elementami, do dyspozycji mamy również opcje dodawania, usuwania oraz edytowania elementów.

By uruchomić projekt należy utworzyć bazę danych.

Utworzenie bazy danych(przy pomocy Mincrosoft SQL Management Studio)  
Otwieramy plik Baza.sql  
W polu "Server Name" wpisujemy "(localdb)\MSSQLLocalDB"  
Klikamy "Connect"  
Klikamy "Execute"  

Po utworzeniu bazy danych możemy uruchomić projekt na dwa sposoby:
 
Sposób 1 (Gdy posiadamy Visual Studio 2019)  
Odnajdujemy Folder TreeView  
TreeView -> TreeView.sln  

Uruchamiamy plik z końca powyższej ściezki w programie Visual Studio 2019.  
Po uruchomieniu programy wraz z projektem, uruchamiamy ów projekt za pomocą przycisku "F5" lub przycisku "IIS Express".  
Po kliknięciu powinno nam się ukazać nowe okno w przeglądarce.  

Sposób 2  
Odnajdujemy Folder TreeView i śledzimy następującą ścieżkę:  
TreeView -> TreeView -> bin -> Debug -> net5.0 -> TreeView.exe  

Plik końcowy jest plikiem wykonywalnym więc klikamy na niego dwukrotnie.  
Po uruchomieniu aplikacji powinien wyświetlić się nam wiersz poleceń jak na na zdjęciu poniżej.  
Kopiujemy zaznaczoną ściezkę po czym otwieramy link w przeglądarce.

![image](https://user-images.githubusercontent.com/103076847/174148386-85ae602c-a58d-4b0f-87c4-65fac569f15a.png)
