City Transport
=============

Interfejs
=========
* Gra będzie położona w angularze, w kontenerze na wielkość monitora minus navbar i footer
* Gra nie będzie w czasie rzeczywistym, pole będzie co jakiś czas odświeżane a gracze będą czerpali aktualny stan z bazy danych
* Nie będzie widać aktualnie jeżdżących autobusów w formie grafiki, jedynie być może w formie tekstowej na jakim przystanku aktualnie są (lub inne środki transportu)
* Będzie natomiast grafika miasta, linii graczy i nasz interfejs posiadanych rzeczy, np. ile mamy pieniędzy

-----------------------------------------------

Położenie:
==========
* Jest kilka miast które gdy są tworzone nie należą do nikogo
* Z czasem miasta powstają
* Miasta można kupić za odpowiednio dużą sumę pieniędzy
* Wtedy należy płacić za miasto w ramach inwestycji, lecz dostajemy bonusy do ilości zbieranych pasażerów
* Miasta posiadają pewną ilość mieszkańców przy powstaniu miasta która z czasem się zwiększa
* W mieście istnieją przystanki które są na start, ale z czasem powstają nowe jeżeli miasto się powiększa
* Ograniczona maksymalna ilość linii może być przypisanych do jednego przystanku zależna od wielkości miasta

------------------------------------------------

Gracze:
=======
* Każdy z graczy zaczyna z pewną sumą pieniędzy która pozwala na zakup podstawowego środka transportu (zaczniemy od autobusu)
* Gracz ma liczone dni od kiedy zaczął grę, jest to staż gracza, dla każego widoczny
* Ostatnia aktywność
* Posiadane miasta
* Posiadane infrastruktury, środki transportu
* Możliwość zapraszania do znajomych, czat (na start może być tylko ogólny, serwerowy)

--------------------------------------------

Rywalizacja, pieniądze
======================
* Pieniądze są zapewnianie przez usługi w postaci komunikacji
* Stawiając swoje linie na przystankach i tworząc odpowiednie plany podróży zarabiamy zabierając ludzi się tam zbierających
* Inni mogą również tworzyć linie na liniach innych graczy lecz każdy gracz im dłużej ma swoją linię na danym przystanku tym większe zaufanie ma ludzi. Ilość ludzi zależy również od komfortu transportu, ceny biletów, częstości przyjeżdżania
* Dostępny ranking, wlicza się w niego ilość przewiezionych pasażerów, pieniądze (włącznie z wartością infrastruktury)
* Jeżeli kupimy miasto to dostajemy bonusy w ilości ludzi korzystających z naszych usług, w ten sposób powoli wypieramy przeciwników lecz opłacamy miasto (jako „inwestycja”)