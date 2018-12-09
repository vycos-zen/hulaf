#!/bin/bash
# cd "${0%/*}"
echo "Building Hulaf controller/client"
npm run concat-hulaf-api
echo "Generating Hulaf controller"
npm run generate-hulaf-api
echo "Generating Hulaf client"
npm run generate-hulaf-api-client


# echo "Building DTO library"
# npm run concat-dto-library
# echo "Generating DTO library"
# npm run generate-dto-library
# echo "Building person controller"
# npm run concat-persons-controller
# echo "Generating person controller"
# npm run generate-persons-controller
# echo "Generating person client"
# npm run generate-persons-client
# echo "Building location controller"
# npm run concat-location-controller
# echo "Generating location controller"
# npm run generate-location-controller   
# echo "Generating location client"
# npm run generate-location-client    