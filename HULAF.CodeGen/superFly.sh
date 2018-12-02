#!/bin/bash

set -o errexit

echo "Building person controller"
npm run concat-persons-controller
echo "Generating person controller"
npm run generate-persons-controller
echo "Generating person client"
npm run generate-persons-client
echo "Building location controller"
npm run concat-location-controller
echo "Generating location controller"
npm run generate-location-controller   
echo "Generating location client"
npm run generate-location-client    