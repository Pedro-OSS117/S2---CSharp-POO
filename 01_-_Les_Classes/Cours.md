# Les Classes

References : 

- https://docs.microsoft.com/fr-fr/dotnet/csharp/programming-guide/classes-and-structs/
- https://docs.microsoft.com/fr-fr/dotnet/csharp/programming-guide/classes-and-structs/classes
- https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/intro-to-csharp/object-oriented-programming
- https://docs.microsoft.com/fr-fr/dotnet/csharp/programming-guide/classes-and-structs/restricting-accessor-accessibility

## I - Des Pointeurs aux Classes

Les Pointeurs ont apporté la notion de référence dans la Programmation Impérative.
La notion de référence est devenue indispensable pour pouvoir faire des programmes de plus en plus complexes.
Lorsqu'on créé des programmes ils doivent être :
- bien conçus pour une bonne compréhension des concepts présents dans le programme,
- facile à maintenir et à améliorer, 
- performant, autant lors execution qu'au niveau de la gestion de la memoire.

Les Classes sont le coeur de la programmation orientée objet. Elles utilisent le principe de référence et sont pensées pour faciliter les points cités ci-dessus.

Le C# est un langage orienté objet. Quatre des techniques clés utilisées dans la programmation orientée objet sont les suivantes :
- L’__encapsulation__ signifie qu’un groupe de propriétés, méthodes et autres membres corrélés est traité comme une unité ou un objet unique.
- L’__héritage__ décrit la possibilité de créer des classes à partir d’une classe existante.
- L'__abstraction__ signifie masquer les détails inutiles des consommateurs de type.
- Le __polymorphisme__ signifie que plusieurs classes peuvent être utilisées de manière interchangeable, même si chacune des classes implémente les mêmes propriétés ou méthodes de manière différente.

### Classes VS Structures

La notion de Classe va permettre de mieux structurer nos programmes en "Concept".
Les Classes sont de __Type Réference__ contrairement aux Structures qui sont de Type Valeur.
Via les classes on va utiliser la notion de référence sans avoir besoin des pointeurs.

On a vu que pour pouvoir faire des références lorsqu'on utilise des types valeurs il faut des pointeurs.
Or en CSharp la memoire est gérée par le Garbage Collector et il ne gère pas les Pointeurs (unsafe).
D'où le fait d'utiliser au maximum les Classes pour organiser nos programmes en POO.
Par contre les structures pourront être utilisées pour des concepts d'objet simple comme par exemple le 'Vector3'.

De plus grâces aux differentes techniques qu'ajoute la POO et qui dépendent des classes on va pouvoir aller beaucoup plus loin dans l'organisation et la conception de nos programmes.

## II - Les Classes - Notion de Concept et d'Instance
https://docs.microsoft.com/fr-fr/dotnet/csharp/programming-guide/classes-and-structs/
https://docs.microsoft.com/fr-fr/dotnet/csharp/programming-guide/classes-and-structs/classes

### 1 - Concept d'une Classe - Création d'une Classe == Creation d'un nouveau type 

En dehors des types de base comme les types numériques, il vous est possible de créer ou d’utiliser d’autres types de données à l’intérieur de vos programmes. Ces types plus complexes seront désignés sous le terme de classes. Dit autrement, une classe est une description d’un nouveau type de données. Tout comme pour le type int, une classe est unique mais permet de créer (ou instancier), plusieurs objets (ou instances).

__Attention__

La classe et l’objet sont des concepts liés mais intrinsèquement différents. Par exemple, prenons un objet réel comme une voiture. Le modèle numérique de la voiture décrit sa forme, ses fonctions, comment elle doit être fabriquée. Ce modèle n’est pas une voiture. De la même manière une classe n’est pas un objet.

![René Magritte "La Trahison des Images"](/01_-_Les_Classes/Annexes/ceci-nest-pas-une-pipe.jpg)

### 2 - Instance d'une Classe -  Type Référence - Null

Lorsqu'on créé une variable de type '__class__', cette variable sera obligatoirement une reference vers l'instance créée.
Lorsqu'on utilise le mot clef '__new__' on créé une instance du type de la class.
On parle aussi d'objet : instance d'une classe == objet d'une classe.
Un type défini comme __class__ est un type référence. 

![Classes et Instances](/01_-_Les_Classes/Annexes/ClasseEtInstance.jpg)

Au moment de l’exécution, quand on déclare une variable de type référence, celle-ci contient la valeur __Null__
tant qu'on a pas explicitement créé une instance de la classe à l’aide de l’opérateur __new__, 
ou qu'on ai assigné un objet existant d’un type compatible, comme indiqué dans l’exemple suivant :

```csharp
// Declaring a reference setted to null. 
// c point to nothing.
MyClass c = null;

// Declaring and instanciate an object of type MyClass.
MyClass mc = new MyClass();

// Declaring another variable of the same type, assigning it the value of the first object.
// mc2 and mc point to the same object
MyClass mc2 = mc;
```

Il est possible d'avoir plusieurs référence vers une même instance.
Si dans une portée il n'y plus de référence alors l'instance sera detruite par le garbage collector, sinon elle reste en mémoire.

## III - Créér une Classe

### 1 - Declaration de la Class == Nouveau Type 

```csharp
// Dans un fichier Person.cs
// Declaration du nouveau type Person
//[access modifier] - [class] - [identifier]
public class Person
{
	
}

// Dans 
public class Program
{
	static void Main(string[] args)
	{
		// Creation d'une instance de la classe (Instantiation)
		Person person = new Person();
	}
}
```

Tous ce qui est déclaré dans la portée de la classe Person, sera accessible uniquement via le type Person.
En général on a : un fichier .cs == 1 class.

#### Classe Interne

Il est tout de même possible de créer plusieurs classe dans un même fichier.
Il est possible aussi de créer une classe dans une classe.
Elle sera dite interne à la Classe et ne pourrat être instancier qu'au travers de la classe qui la contient.

```csharp
public class Program
{
    static void Main(string[] args)
    {
    }
}

public class Person
{
    // Classe interne private (ne peut pas être instancié hors de la classe Person)
    class InternalPersonPrivate
    {
    }

    // Classe interne public
    public class InternalPerson
    {
    }
}
```

### 2 - Propriétés

Lorsqu'on défini une classe en général on lui ajoute des propriétés.
Convention : Ces propriétés dites membres sont déclarées juste en dessous du nom de la classe.
Nomenclature : '_' devant le nom de la propriété, celà permet de savoir que c'est une propriété quand elle est utilisée ailleurs dans le code.

Les propriétés sont des données définissants la classe.
Lorsqu'on décide d'ajouter des propriétés à une classe il faut suivre le principe d'encapsulation.
    
```csharp
public class MyClass
{
    // -------- Ici on déclare les propriétés membres de la classe
    // Nomenclature => '_' devant le nom de la propriété.
    private string _propsMember;
    
    // -------- Ici on déclare les propriétés membres de la classe
}
```

### 3 - Constructeurs

Lorsqu'on utilise le mot clef '__new__' pour instancier une classe, on appelle en fait un Constructeur.

#### Constructeur par defaut
Il y a toujours un constructeur par defaut pour une classe même si aucun constructeur n'est déclaré.
On peut donc créer une instance d'une classe avec el mot clef 'new' même si aucun constructeur n'est déclaré.
L'instance de la classe aura alors toutes ses propriétés intialisées par des valeurs par defaut.
On peut déclarer et implementer le constructeur par defaut pour qu'à la création un conmportement particulié soit executer.
Le constructeur par defaut est celui sans paramètres.
```csharp
public class MyClass
{
    private string _propsMember;
    
    // Constructeur par defaut surchargé
    public MyClass()
    {
        Console.WriteLine("Bonjour, je suis une instance de my class et je viens d'être créée via le constructeur par defaut");
    }
}
```

#### Constructeur
Un constructeur a comme signature :

```csharp
public class MyClass
{
    private string _propsMember;

    // Constructeur avec paramètres et intialisation de propriétés
    public MyClass(string propsValue)
    {
        _propsMember = propsValue;
        Console.WriteLine("Bonjour, je suis une instance de my class et je viens d'être créé via un constructeur");
    }
}
```

### 4 - Methodes

```csharp
public class MyClass
{
    private string _propsMember;
    
    // [Accessibilité] [Type retour] [Identifiant] [Parametres]
    public void MyMethod(int param1, float param2)
    {
        // Do Something
    }
}
```

### 5 - Variables et Fonctions static d'une classe

https://openclassrooms.com/fr/courses/218202-apprenez-a-programmer-en-c-sur-net/216869-les-classes-2-2

Les classes peuvent avoir des methodes et des variables static. Elles sont :
- Accessibles à l'éxécution dès que le type est chargé.
- Pas besoin d'instance pour être utilisées
- On utilise le nom de la classe pour les appeler.

```csharp
public class MyClass
{
    // Globale au programme lorsque MyClass est chargée 
    public static string myStaticVar;
    
    // Fonction static, utilisable sans instance.
    // Dans cette portée on a pas accès aux propriétés des instances
    public static void MyMethodSatic(int param1, float param2)
    {
        // Do Something
    }
}


public class Program
{
    static void Main(string[] args)
    {
        // Je peux appeler ma variable satic sans instance.
    	MyClass.myStaticVar = "nouvelle valeur";
	// Je peux appeler ma fonction sans instance.
	MyClass.MyMethodSatic(10, 1);
    }
}
```

## IV - Encapsulation et Accesseurs
https://docs.microsoft.com/fr-fr/dotnet/csharp/tutorials/intro-to-csharp/object-oriented-programming

https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/intro-to-csharp/object-oriented-programming

https://docs.microsoft.com/fr-fr/dotnet/csharp/programming-guide/classes-and-structs/

### Encapsulation
L’encapsulation est parfois considérée comme le premier pilier ou principe de la programmation orientée objet. 
D'après le principe d'encapsulation, une classe ou un struct peut spécifier le degré d'accessibilité de chacun 
de ses membres au code situé en dehors de la classe ou du struct. Les méthodes et variables qui ne sont pas 
destinées à être utilisées d’en dehors de la classe ou de l’assembly peuvent être masquées afin de limiter 
le risque d’erreurs ou de code malveillant exploitant une faille de sécurité.

### Accessibilité private, public
Certaines méthodes et propriétés sont censées être appelées ou accessibles par le code qui se trouve à l’extérieur de votre classe ou de votre struct, connu sous le terme de code client. D’autres méthodes et propriétés peuvent être uniquement utilisables dans la classe ou le struct proprement dits. Il est important de limiter l’accessibilité de votre code afin que seul le code client prévu puisse y accéder. Vous pouvez spécifier l’accessibilité de vos types et de leurs membres vis-à-vis du code client à l’aide des modificateurs d’accès public, protected, internal, protected internal, private et private protected. L’accessibilité par défaut est private. Pour plus d’informations, consultez Modificateurs d’accès.

### Accesseurs
https://docs.microsoft.com/fr-fr/dotnet/csharp/programming-guide/classes-and-structs/restricting-accessor-accessibility

Les parties get et set d’une propriété ou d’un indexeur sont appelées accesseurs. Par défaut, ces accesseurs ont la visibilité ou le niveau d’accès de la propriété ou de l’indexeur auquel ils appartiennent. Pour plus d’informations, consultez Niveaux d’accessibilité. Toutefois, il peut parfois s’avérer utile de restreindre l’accès à l’un de ces accesseurs. En général, cela implique de restreindre l’accessibilité de l’accesseur set, tout en gardant l’accesseur get publiquement accessible. Par exemple :

```csharp
public class MyClass
{
    // Nomenclature => '_' devant le nom de la propriété.
    private string _propsMember;

    // Accesseur de la propriété _propsMember
    public string PropsMember
    {
       get { return _propsMember; }
       set { _propsMember = value; }
    }
}

class Program
{
    static void Main(string[] args)
    {    
        MyClass refMyClassInstance = new MyClass();
	
	// Appel de l'accesseur
        refMyClassInstance.PropsMember = "NewValue";
    }
}
```
