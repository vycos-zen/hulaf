FROM node:10.12.0 AS hulaf-build

# install chrome for protractor tests
# RUN wget -q -O - https://dl-ssl.google.com/linux/linux_signing_key.pub | apt-key add -
# RUN sh -c 'echo "deb [arch=amd64] http://dl.google.com/linux/chrome/deb/ stable main" >> /etc/apt/sources.list.d/google.list'
# RUN apt-get update && apt-get install -yq google-chrome-stable

ARG configuration=production

WORKDIR /app

COPY ./ /app/

# ENV PATH /app/node_modules/.bin:$PATH

COPY package.json app/package.json
RUN npm install
# RUN npm install -g @angular/cli@7.0.2

RUN npm run build -- --output-path=./dist/out --configuration $configuration

FROM nginx:1.15.6-alpine AS nginx

COPY ./nginx.conf /etc/nginx/nginx.conf
COPY --from=hulaf-build /app/dist/out /usr/share/nginx/html