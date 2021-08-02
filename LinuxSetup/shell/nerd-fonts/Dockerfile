FROM alpine:3.11

LABEL org.opencontainers.image.title="Nerd Fonts Patcher" \
      org.opencontainers.image.description="Patches developer targeted fonts with a high number of glyphs (icons)." \
      org.opencontainers.image.url="https://www.nerdfonts.com/" \
      org.opencontainers.image.source="https://github.com/ryanoasis/nerd-fonts" \
      org.opencontainers.image.licenses="MIT"

RUN apk add fontforge --repository=http://dl-cdn.alpinelinux.org/alpine/edge/testing && \
    apk add --no-cache py2-pip && \
    pip install configparser

# sys.stdout.write encoding (py)
ENV PYTHONIOENCODING=utf-8

VOLUME /in /out
COPY . /nerd

ENTRYPOINT [ "/bin/sh", "/nerd/bin/scripts/docker-entrypoint.sh" ]
