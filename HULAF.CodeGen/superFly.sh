#!/bin/bash

set -o errexit

echo "Building person controller"
npm run concat-persons-controller
npm run generate-persons-controller
npm run generate-persons-client
echo "Building location controller"
npm run concat-location-controller
npm run generate-location-controller    
npm run generate-location-client    