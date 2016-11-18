# CShark ptiChat

Notre code source a été écrit en **C#** et développé sous *Visual Studio 2015*.

### Architecture

Le projet est constitué de 3 sous-projets :
- **CSharkLibrary** qui est une librairie contenant les interfaces et classes communes au client et au serveur
- **CSharkClient** qui est le code *WPF* implémentant la partie cliente
- **CSharkServer** qui implémente la partie serveur en *WCF*

### Compilation

Pour compiler le serveur et le client, il est nécessaire d'inclure la librairie commune CSharkLibrary :
1. File -> Add -> Existing Project
2. Sélectionner le fichier .csproj de la libraire CSharkLibrary
3. Dans le panneau Solution Explorer à droite, Clic droit -> Add references -> Projects -> Solution
4. Cocher CSharkLibrary

NB : Il est possible qu'il soit nécessaire de supprimer une référence à *CSharkLibrary* déjà existante.

Ensuite, un clic sur le bouton *Start* devrait lancer la compilation.

### Run

Une fois le serveur et le client compilés, il faut se rendre de le répertoire bin/Debug/ des projets pour trouver les exécutables.

1. Lancer le fichier **CSharkServer.exe**. Une console Windows devrait alors se lancer.

![CSharkServer Start](https://github.com/groupeCShark/CSharkServer/tree/dev/images/CSharkServerStart.png "CSharkServer Start")

2. Lancer autant de clients **CSharkClient.exe** que nécessaire. Une fenêtre de *chat* devrait alors se lancer et la connexion au serveur devrait réussir.

![CSharkClient Start](https://github.com/groupeCShark/CSharkServer/tree/dev/images/CSharkClientStart.png "CSharkClient Start")

