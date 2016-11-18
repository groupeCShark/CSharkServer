# CShark ptiChat

Notre code source a �t� �crit en **C#** et d�velopp� sous *Visual Studio 2015*.

### Architecture

Le projet est constitu� de 3 sous-projets :
- **CSharkLibrary** qui est une librairie contenant les interfaces et classes communes au client et au serveur
- **CSharkClient** qui est le code *WPF* impl�mentant la partie cliente
- **CSharkServer** qui impl�mente la partie serveur en *WCF*

### Compilation

Pour compiler le serveur et le client, il est n�cessaire d'inclure la librairie commune CSharkLibrary :
1. File -> Add -> Existing Project
2. S�lectionner le fichier .csproj de la libraire CSharkLibrary
3. Dans le panneau Solution Explorer � droite, Clic droit -> Add references -> Projects -> Solution
4. Cocher CSharkLibrary

NB : Il est possible qu'il soit n�cessaire de supprimer une r�f�rence � *CSharkLibrary* d�j� existante.

Ensuite, un clic sur le bouton *Start* devrait lancer la compilation.

### Run

Une fois le serveur et le client compil�s, il faut se rendre de le r�pertoire bin/Debug/ des projets pour trouver les ex�cutables.

1. Lancer le fichier **CSharkServer.exe**. Une console Windows devrait alors se lancer.

![CSharkServer Start](https://github.com/groupeCShark/CSharkServer/tree/dev/images/CSharkServerStart.png "CSharkServer Start")

2. Lancer autant de clients **CSharkClient.exe** que n�cessaire. Une fen�tre de *chat* devrait alors se lancer et la connexion au serveur devrait r�ussir.

![CSharkClient Start](https://github.com/groupeCShark/CSharkServer/tree/dev/images/CSharkClientStart.png "CSharkClient Start")

