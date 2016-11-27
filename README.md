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

![CSharkServer Start](/images/CSharkServerStart.png?raw=true "CSharkServer Start")

2. Lancer autant de clients **CSharkClient.exe** que nécessaire. Une fenêtre de *chat* devrait alors se lancer et la connexion au serveur devrait réussir.

![CSharkClient Start](/images/CSharkClientStart.png?raw=true "CSharkClient Start")


### Utilisation

##### Client

L'interface cliente est plutôt simple et intuitive.

L'envoie de fichiers se fait en cliquant sur le bouton File. Les fichiers envoyés se retrouvent dans un répertoire /download dans le dossier de lancement de l'application.

Le pseudo par défaut est "Anonymous". Il peut être changé dans le fichier config.xml. Un redémarrage est alors nécessaire pour prendre en compte les modifications. La commande `!username <Votre Nouveau Pseudo>` permet également de modifier le pseudo tout en utilisant l'application.


##### Serveur

L'utilisation du serveur reste également très simple. Une fois lancé, la commande `help` affiche l'ensemble des commandes supportés.

Par exemple, la commande `userlist` affiche la liste des utilisateurs actuellement connectés.