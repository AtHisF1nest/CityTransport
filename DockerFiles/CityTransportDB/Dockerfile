FROM postgres:latest

COPY ./postgresql.conf /etc/postgresql/postgresql.conf

ENV POSTGRES_USER citytransportuser
ENV POSTGRES_DB citytransportdb
ENV POSTGRES_PASSWORD citytransportpw

EXPOSE 5432