# Lernperiode 6

## Einführung
Ich möchte ein Projekt umsetzen, in dem man einen **Krieger** spielt. Zu Beginn kann man zwischen drei Waffen auswählen und startet auf **Level 1**. Danach erscheinen fortlaufend Angreifer, die abgewehrt werden müssen. Der Krieger verfügt über drei verschiedene Angriffe, mit denen er die Gegner besiegen kann. Auch die Angreifer besitzen ein Level – je höher dieses ist, desto schwieriger sind sie zu besiegen.

## 29.08.2025
- [x] Plan auf einem Blatt erstellen (offline)  
- [x] Krieger erstellen  
- [ ] Krieger soll Waffen auswählen können  

![WhatsApp Bild 2025-08-29 um 09 25 52_f41a7aab](https://github.com/user-attachments/assets/192d2da4-1eb6-4225-8a3f-9d0c01bb0868)

Ich habe heute **zwei von drei Arbeitspaketen** abgeschlossen. Ich habe zwei Krieger sowie die dazugehörigen Waffen erstellt. Allerdings habe ich es noch nicht geschafft, dass die Waffen auch ausgewählt werden können. Das werde ich in der nächsten Woche in Angriff nehmen.

## 05.09.2025
- [x] Waffenauswahl für den Spieler  
- [x] HP hinzufügen  
- [x] Level für den Spieler hinzufügen  
- [x] Plan für Angreifer im Spiel erstellen (offline)  

![WhatsApp Bild 2025-09-05 um 11 15 11_64116214](https://github.com/user-attachments/assets/02051881-295c-4734-89c2-1c78022bffc0)

Heute habe ich viel gearbeitet und **alle geplanten Arbeitspakete** abgeschlossen. Ich habe die Waffen erstellt und sie abhängig von der Spielerauswahl zugewiesen. Der Benutzer kann nun die Waffen auswählen. Zusätzlich habe ich neue Klassen für **Level** und **Spiel** erstellt. Im Spiel werden die Level mit HP, Power und XP verwaltet. In Zukunft soll bei Erreichen der benötigten XP automatisch ein Level-Up erfolgen, sodass ein klarer Fortschritt sichtbar ist.

## 12.09.2025
- [x] Gewöhnlichen Angreifer erstellen  
- [x] Spieler auf Level 1 setzen und ersten Kampf programmieren (Angreifen / Ausweichen)  
- [x] XP-Logik hinzufügen (XP-Drops aufnehmen und hinzufügen)  
- [ ] Zufällige Waffenauswahl für Angreifer  

Ich habe nahezu alle Arbeitspakete abgeschlossen. Das letzte habe ich bewusst nicht umgesetzt, da mir beim Programmieren aufgefallen ist, dass Waffen für Angreifer keinen relevanten Einfluss auf das Spiel haben. Dafür habe ich den **ersten Kampf** programmiert. Der Spieler startet automatisch auf Level 1 und kann angreifen oder ausweichen. Die Aktion des Angreifers wird zufällig bestimmt.  
- Weichen beide aus, passiert nichts.  
- Greift einer an und der andere weicht aus, besteht eine **25 % Trefferchance**.  
- Greifen beide an, hat der Angreifer eine **40 %** und der Spieler eine **60 % Trefferchance**.  

Die XP-Logik funktioniert ebenfalls: Wird die benötigte XP-Menge erreicht, erfolgt automatisch ein Level-Up.

## 19.09.2025
- [x] Konsole mit Farben gestalten  
- [x] Zufällige Angreifer erstellen (nicht immer derselbe)  
- [x] Anfangs schwache Gegner, am Schluss Boss-Logik  
- [x] Extras hinzufügen (Heiltränke, Extra-Leben usw.)  

Heute habe ich viel erreicht. Es werden nun **zufällige Gegner** erzeugt. Auf Level 1 und 2 erscheint nur der Räuber, mit steigendem Level kommen stärkere Gegner hinzu. Zusätzlich habe ich **Heiltränke** implementiert. Mit einer gewissen prozentualen Chance lässt ein besiegter Gegner einen Heiltrank fallen, den man anschliessend benutzen kann. Die Konsole habe ich zudem farblich gestaltet, wodurch sie übersichtlicher wirkt.

## 17.10.2025
- [x] Verschiedene Heiltränke erstellen (unterschiedliche Heilwerte)  
- [x] Gifttränke erstellen (negative Effekte bei Nutzung)  
- [ ] Neue Angreifer  

## Ende des Projekts
Ich habe ein Spiel erstellt, in dem man einen **Krieger** spielt. Zuerst wählt man den Krieger und anschliessend eine Waffe. Im Spiel wird zufällig ein Angreifer ausgewählt, der beim Sieg XP fallen lässt. Mit diesen XP kann man Level aufsteigen und dadurch stärker werden. Gleichzeitig werden jedoch auch die Angreifer immer stärker.

Je nach gewähltem Krieger stehen unterschiedliche Waffen zur Verfügung.

<img width="665" height="388" alt="image" src="https://github.com/user-attachments/assets/92fcb4cf-5f13-414e-90b7-ad8da7768f50" />

In der aktuellen Spielsituation wird der Spieler von einem Dorfbewohner angegriffen. Man sieht dessen Lebenspunkte und Angriffsstärke und kann entscheiden, ob man angreift oder ausweicht. Die Aktion des Gegners wird durch einen Zufallsmechanismus bestimmt.

<img width="1260" height="403" alt="image" src="https://github.com/user-attachments/assets/2a492a9c-6f27-4a68-a7b3-cfdc094df1c2" />

## Reflexion
Ich bin sehr zufrieden mit meinem Projekt und finde, dass es mir insgesamt gut gelungen ist. Anfangs lief alles relativ reibungslos, doch mit der Zeit traten immer mehr kleinere Probleme auf, die ich lösen musste. Das war teilweise frustrierend, hat mir aber viel Lerngewinn gebracht.

Rückblickend habe ich auch einige unnötige Funktionen eingebaut, die mir am Ende keinen Mehrwert gebracht haben. Beispielsweise waren die Waffen zu wenig ins Gameplay integriert – hier hätte ich mehr daraus machen können. Das ärgert mich zwar ein wenig, ist aber nicht weiter schlimm. Wichtig ist, dass das Projekt abgeschlossen ist und insgesamt stabil läuft.
