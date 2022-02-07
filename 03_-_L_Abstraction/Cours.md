# L'Abstraction

References : 

- https://docs.microsoft.com/fr-fr/dotnet/csharp/tutorials/intro-to-csharp/object-oriented-programming
- https://docs.microsoft.com/fr-fr/dotnet/csharp/tutorials/inheritance
- https://docs.microsoft.com/fr-fr/dotnet/csharp/programming-guide/classes-and-structs/inheritance

## 1 - Qu'est ce que l'Abstraction en POO

L'abstraction permet d'élaborer un concept sous forme de classe qui ne pourrat pas être instancier.
Le concept définis des comportements (méthodes) mais ne les implémentes pas.
Ensuite des classes representant des cas concrets deriverons de ce concept et
ce concept, par le principe d'abstraction imposera à toutes ses filles l'__obligation d'implémenter toutes__ les méthodes de la mère.

Pour empêcher l’instanciation directe, vous pouvez déclarer une classe comme étant abstract à l’aide de l’opérateur new.
Une classe abstraite ne peut être utilisée que si une nouvelle classe en est dérivée. Une classe abstraite peut contenir une ou plusieurs signatures de méthode qui sont également déclarées comme abstraites. Ces signatures spécifient les paramètres et la valeur de retour, mais n’ont aucune implémentation (corps de méthode). Une classe abstraite ne doit pas contenir de membres abstraits ; Toutefois, si une classe contient un membre abstrait, la classe elle-même doit être déclarée comme abstraite. Les classes dérivées qui ne sont pas abstraites elles-mêmes doivent fournir l’implémentation pour toutes les méthodes abstraites d’une classe de base abstraite. 

Exemples de concepts abstraits VS objets concrets ou "rééls":

- Vehicule       VS     Voiture, Vélo, Camion, etc
- Figure         VS     Square, Circle, etc
- Documents      VS     Livre, Roman, Revue, Article, etc
- CompteBancaire VS     Compte Epargne, Compte Courant, etc
- Animal         VS     Reptile, Oiseau, Mammifere, etc

## 2 - Mot clef abstract

- https://docs.microsoft.com/fr-fr/dotnet/csharp/programming-guide/classes-and-structs/abstract-and-sealed-classes-and-class-members

Le mot clé abstract vous permet de créer des classes et des membres de class qui sont incomplets et doivent être implémentés dans une classe dérivée.

Dans certains cas, une classe dérivée __doit__ remplacer l’implémentation de la classe de base. 
Les membres de classe de base marqués avec le mot-clé __abstract__ requièrent que les classes dérivées les remplacent. 

```csharp
public abstract class A
{
    public abstract void Method1();
}

public class B : A // Generates CS0534.
{
    public void Method3()
    {
        // Do something.
    }
}
```

Considérons un logiciel de dessin vectoriel. Ce logiciel de dessin doit être capable de manipuler différents objets : des ellipses, des rectangles… 

Il va donc être util de les regrouper dans une même hiérarchie avec un parent commun : Shape. Il sera naturel d’utiliser une méthode polymorphe Draw() pour ces objets. Cependant la classe Shape ne contient pas d’information géométrique et elle ne sait pas se dessiner : on ne sait pas quoi écrire dans la méthode Draw de la classe Shape.

Lorsque l’on a identifié un cas tel que la classe Shape qui doit posséder une méthode dont on ne peut déterminer le contenu mais qui devra être définie dans les classes filles, il s’agit d’une classe abstraite et d’une méthode abstraite. On ajoute alors le qualificatif absract à la classe et à la méthode:

```csharp
abstract class Shape
{
        protected string nom ;
        public abstract void Draw() ;   // méthode abstraite : pas de block {}
}

class Triangle : Shape
{
        protected Point p1, p2, p3 ;
        public override void Draw()     { ... } // (re)définition de la méthode Draw
}
```

On remarque qu’une méthode abstraite est automatiquement virtuelle. Par contre, il faut utiliser le qualificatif override lors de sa définition dans les sous-classes.

Une classe abstraite ne peut pas être instanciée (elle est incomplète car les méthodes abstraites n’ont pas de corps), ce qui ne l’empêche pas de posséder un ou plusieurs constructeurs appelés par le mécanisme de chaînage des constructeurs.

__Important__

Une classe non abstraite fille d’une classe abstraite doit implémenter toutes les méthodes abstraites de sa classe mère.

## 3 - Méthodes abstraites VS virtuelles

Lorsqu’une classe de base déclare une méthode en tant que virtual , une classe dérivée __peut__ override la méthode avec sa propre implémentation. 
Si une classe de base déclare un membre en tant que abstract , cette méthode __doit__ être substituée dans toute classe non abstraite qui hérite directement de cette classe. 

Si une classe dérivée est abstraite, elle hérite des membres abstraits sans les implémenter. 
Les membres virtuels et abstraits sont la base du polymorphisme, qui est la deuxième caractéristique principale de la programmation orientée objet. 
Pour plus d’informations, consultez Polymorphisme (https://docs.microsoft.com/fr-fr/dotnet/csharp/programming-guide/classes-and-structs/polymorphism).

Notes

Il est recommandé que les membres virtuels utilisent base pour appeler l'implémentation de classe de base de ce membre dans leur propre implémentation. L'exécution du comportement de classe de base permet à la classe dérivée de se concentrer sur l'implémentation du comportement spécifique à la classe dérivée. Si l'implémentation de classe de base n'est pas appelée, la classe dérivée doit rendre son comportement compatible avec le comportement de la classe de base.
