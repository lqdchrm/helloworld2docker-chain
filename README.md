---
title: Experiment to learn dockerization
author: RORO
date: 2020-05-26
---

# Experiment to learn dockerization

Starting from a plain hello world App, we want to learn what needs to be done for creating and running a multi-container "app".

=> Journey from Dev to DevOps with Containers

Goal: Learn how to work with containers, as a base for decision making, when planning for a microservice architecture.

## Environment

C#, dotnet core , docker, shell scripts, nuget

## Start

- blank workspace

## DoD

- multiple console apps running in seperate docker containers
- use each of those processes from a batch file to fulfill a busines-case

## Example Business Case

- Add two numbers:
  - Input two numbers via console
  - Get added numbers printed on console

## Planned Journey Milestones

### Phase 1: [DEV] BusinessLogic

#### Bootstrapping

[ ] Create standalone Console app

[ ] Implement Business Use-Case

#### Milestone 1

[ ] working Business Use-Case

### Phase 2: [DEV] Business-Case Modularization

#### Functional Refactoring

[ ] Separate Business-Tasks on function level

[ ] Separate Business-Tasks on project level

[ ] Separate Business-Tasks on executable level

[ ] Use executables from batch file on same machine

#### Milestone 2

[ ] Working Business Use-Case spanning multiple-executables

### Phase 3: [DEV] Technical Modularization aka Containerization

#### Operational Refactoring

[ ] Separate Business-Tasks on container level

[ ] Use containers from batch file (without orch.)

[ ] Impl container orchestration

[ ] Use containers from batch file (with orch.)

#### Milestone 3

[ ] Working Business Use-Case spanning multiple containers with simple service startup

### (optional) Phase 4: [DEV] Build Modularization

#### Build-Chain

[ ] dockerize builds for CI
